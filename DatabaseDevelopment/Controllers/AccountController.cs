using System.Threading.Tasks;
using DatabaseDevelopment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Helpers;
using Microsoft.AspNetCore.Http;

namespace DatabaseDevelopment.Controllers
{
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
        
        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]

        public async Task<IActionResult> Register(string login, string password, string confirmPassword){
            if (password != confirmPassword) return Content("Пароли не совпадают");
            using (MyDbContext myDbContext = new MyDbContext()){
                User user = await myDbContext.Users.FirstOrDefaultAsync(x => x.Login == login);
                if (user is null){
                    user = new User { Login = login, Password =password };
                    user.RoleId = myDbContext.Roles.FirstAsync(x => x.Name == "user").Id;
                    myDbContext.Users.Add(user);
                    await myDbContext.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(string login, string password){
            using (MyDbContext myDbContext = new MyDbContext()){
                User user = await myDbContext.Users.FirstOrDefaultAsync(x => x.Login == login && x.Password == password);
                if (user is not null){
                    var currUser = new SessionHelper<User>(this);
                    if (currUser["user"] is not null){
                        return Content("Вы уже в системе, вы должны выйти");
                    }
                    else
                        currUser["user"] = user; 
                    return RedirectToAction("Index", "Home");
                }
                return Content("Такого пользователя не существует");
            }
        }
    }
}