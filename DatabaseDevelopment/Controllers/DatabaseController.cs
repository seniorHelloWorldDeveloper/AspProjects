using ClassLibrary.Helpers;
using DatabaseDevelopment.Attributes;
using DatabaseDevelopment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DatabaseDevelopment.Controllers
{
    public class TableInfo{
        public IEnumerable<string> Columns { get; set; }
        public IEnumerable<IEnumerable<string>> Values { get; set; }
        public IEnumerable<string> Tables { get; set; }    
        public string TableName { get; set; }
    }

    public class OwnSqlCommand{
        public string QueryString { get; set; }
    }
    public class DatabaseController : Controller
    {

        [HasRole("admin")]
        [HttpGet]
        public IActionResult GetConnection() => View();

        //Вот бы тут yield return юзать.. Но нельзя же его в трай кетче юзать(

        private async Task<List<string>> GetTables(string connString){
            try{
                SqlConnection sqlConnection = new SqlConnection(connString);
                await sqlConnection.OpenAsync();
                DataTable dt = await sqlConnection.GetSchemaAsync("Tables");
                List<string> tables = new List<string>();
                foreach (DataRow dataRow in dt.Rows)
                    tables.Add((string)dataRow[2]);
                await sqlConnection.CloseAsync();
                return tables;
            }
            catch (Exception){
                return null;
            }
        }

        [HttpPost]
        [HasRole("admin")]
        public async Task<IActionResult> GetConnection(string connString){
            var tables = await GetTables(connString);
            if (tables is null){
                return Content(@"<head><meta charset=""utf-8""></head><body><p color=""red"">Неккоректаня строка подключения</p><body/>", "text/html");
            }
            new SessionHelper<ConnectionString>(this)["connString"] = new ConnectionString() { ConnString = connString, User = new SessionHelper<User>(this)["user"], Tables = tables};
            return Content("<!DOCTYPE html><html><head><meta charset=\"utf-8\"/></head><body><p>Успешное подключение!</p><a href=\"/Database/Tables\">К таблицам..</a></body></html>", "text/html");
        }

        private async Task<(IEnumerable<string>, IEnumerable<IEnumerable<string>>)> GetTableInfo(string tableName, SqlConnection connection, bool isOwnQuery = false, string query = null){
                try{
                    IEnumerable<string> columns = new List<string>();
                    IEnumerable<IEnumerable<string>> values = new List<List<string>>();
                    SqlCommand sqlCommand = new SqlCommand((isOwnQuery ? query : $"SELECT * FROM {tableName}"), connection);
					if (!isOwnQuery)
						connection.Open();
					
                    using (SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync()){
                        while (await sqlDataReader.ReadAsync()){
                            for (int i = 0; i < sqlDataReader.FieldCount; i++){
                                if (!columns.Any(x => x == sqlDataReader.GetName(i))){
                                    columns = columns.Append(sqlDataReader.GetName(i));
                                }
                            }
                            IEnumerable<string> val = new List<string>();
                            for (int i = 0; i < sqlDataReader.FieldCount; i++){
                                var columnAsString = sqlDataReader.GetValue(i).ToString();
                                val = val.Append(columnAsString);
                            }
                            values = values.Append(val);
                        }
                    }
					
		    if (connection.State == ConnectionState.Open)
			connection.Close();
                    return (columns, values);
                }
                catch (SqlException){
                    return (Enumerable.Empty<string>(), Enumerable.Empty<IEnumerable<string>>());
                }
        }

        [HasRole("admin")]
        [RequireConnectionString]
        [Route("/Database/Tables/{name?}")]
        public IActionResult Tables(string name){
            if (name is null){
                return View(new TableInfo() { Tables = new SessionHelper<ConnectionString>(this)["connString"].Tables });
            }
            else{
                var currConnection = new SqlConnection(new SessionHelper<ConnectionString>(this)["connString"].ConnString);
                try{
                    (IEnumerable<string>, IEnumerable<IEnumerable<string>>) value = GetTableInfo(name, currConnection).GetAwaiter().GetResult();
                    var tableInfo = new TableInfo() { Values = value.Item2, Columns = value.Item1, TableName = name };
                    return View(tableInfo);
                }
                catch (SqlException){
                    return Content("Неизвестная таблица.");
                }
            }
        }

        private bool IsSelect(string queryString){
            queryString = Regex.Replace(queryString, "\\s+", " ");
            return queryString.Trim().Split(' ').First().ToLower() == "select";
        }

        [HasRole("admin")]
        [RequireConnectionString]
        [Route("Database/Query")]
        [HttpGet]
        public IActionResult Query() =>
            View();

        [HasRole("admin")]
        [RequireConnectionString]
        [Route("Database/Query")]
        [HttpPost]
        public async Task<IActionResult> Query(string queryString){
            if (string.IsNullOrWhiteSpace(queryString)){
                return Content("Пустой запрос?..");
            }
            if (IsSelect(queryString)){
                return Content("Селект запросы не обрабатываем.");
            }
            using (SqlConnection sqlConnection = new SqlConnection(new SessionHelper<ConnectionString>(this)["connString"].ConnString)){
                try{
                    await sqlConnection.OpenAsync();
                    SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                    await sqlCommand.ExecuteNonQueryAsync();
                    return Content("Запрос был успешно обработан.");
                }
                catch (SqlException e){
                    return Content("Произошла ошибка при обработки вашего запроса.\n" + e.Message);
                }
            }
        }
        
        [Route("Database/Query/Select")]
        [HasRole("admin")]
        [RequireConnectionString]
        [HttpGet]
        public IActionResult Select() =>
            View();

        [Route("Database/Query/Select")]
        [HasRole("admin")]
        [RequireConnectionString]
        [HttpPost]
        public IActionResult Select(string queryString){
            if (string.IsNullOrWhiteSpace(queryString))
                return Content("Пустой запрос?..");

            if (!IsSelect(queryString))
                return Content("Не селект запросы не принимаем..");
            var currConnection = new SqlConnection(new SessionHelper<ConnectionString>(this)["connString"].ConnString);
            new SessionHelper<OwnSqlCommand>(this)["sqlQuery"] = new OwnSqlCommand() { QueryString = queryString };
            return RedirectToAction("GetSelect");
        }

        [HasRole("admin")]
        [RequireConnectionString]
        public async Task<IActionResult> GetSelect(){
            OwnSqlCommand currComand = new SessionHelper<OwnSqlCommand>(this)["sqlQuery"];
            if (currComand is null){
                return Content("Не прилично самому переходить на страничку..");
            }
            ConnectionString connString = new SessionHelper<ConnectionString>(this)["connString"];
            using(SqlConnection sqlConnection = new SqlConnection(connString.ConnString)){
                await sqlConnection.OpenAsync();
                (IEnumerable<string>, IEnumerable<IEnumerable<string>>) value = await GetTableInfo(null, sqlConnection, true, currComand.QueryString);
                if (value == (Enumerable.Empty<string>(), Enumerable.Empty<IEnumerable<string>>())){
                    return Content("Произошла ошибка при обработке вашего sql запроса, или он ничего не вывел.");
                }
                var tableInfo = new TableInfo() { Values = value.Item2, Columns = value.Item1 };
                await sqlConnection.CloseAsync();
                return View(tableInfo);
            }   
        }
    }
}
