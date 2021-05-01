using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Shop.Helpers;
using Shop.Models;
using static Shop.Helpers.SessionHelper;

namespace Shop.Controllers
{
    
    public class MainController : Controller
    {
        public IActionResult Index() => View(new MyDbContext().AllPizzas);

        [Route("Cart")]
        public IActionResult Cart(){
            var cart = SessionHelper.GetObjectFromJson<List<PizzaModel>>(HttpContext.Session, "cart");
            if (cart is not null) ViewBag.total = cart.Sum(x => x.Amount * x.Pizza.Price);
            return View(cart);
        }

        [Route("AddToCart/{id?}"), HttpGet]
        public IActionResult AddToCart(int? id){
            MyDbContext myDbContext = new();
            if (id is null || !myDbContext.AllPizzas.Any(x => x.Id == (int)id)) return RedirectToAction("Index");
            return View(myDbContext.AllPizzas.FirstOrDefault(x => x.Id == Convert.ToInt32(id)));
        }


        [Route("AddToCart/{id?}"), HttpPost]
        public IActionResult AddToCart(int? id, bool maso, bool lychok, bool tomats, string centimeter, int count){
            if (centimeter is null) return Content("Выберите длнну пиццы.");
            if (count == 0) return Content("Выберите кол-во пицц.");
            var cart = SessionHelper.GetObjectFromJson<List<PizzaModel>>(HttpContext.Session, "cart");
            int centimeters = Convert.ToInt32(centimeter);
            PizzaModel currModel = new PizzaModel { Id = Startup._cartPosition++, Pizza = new MyDbContext().AllPizzas.First(x => x.Id == (int)id), Centimeters = centimeters, Meat = maso , Onion = lychok, Tomatoes = tomats, Amount = count };
            if (cart == null){
                List<PizzaModel> newCart = new();
                newCart.Add(currModel);
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", newCart);
            }
            else{
                cart.Add(new PizzaModel { Pizza = new MyDbContext().AllPizzas.First(x => x.Id == (int)id), Centimeters = centimeters, Meat = maso , Onion = lychok, Tomatoes = tomats , Amount = count });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Cart");
        }

        [Route("Buy/{id?}"), HttpGet]
        public IActionResult Buy(int? id){
            if (id is null) return RedirectToAction("Error");
            var PizzaModel = SessionHelper.GetObjectFromJson<List<PizzaModel>>(HttpContext.Session, "cart");
            if (PizzaModel is null || !PizzaModel.Any(x => x.Id == id)) return RedirectToAction("Error");
            return View(PizzaModel.First(x => x.Id == id));
            
        }

        [Route("Buy/{id?}"), HttpPost]
        public IActionResult Buy(int? id, string name, string adress, string telephonenumber){
            using(MyDbContext myDbContext = new MyDbContext()){
                var myCart = SessionHelper.GetObjectFromJson<List<PizzaModel>>(HttpContext.Session, "cart");
                PizzaModel first = myCart.First(x => x.Id == id);
                myDbContext.AllOrders.Add(new Order { PizzaName = first.Pizza.Name, UserName = name, Adress = adress, Telephone = telephonenumber, Meat = first.Meat, Onion = first.Onion, Tomatoes = first.Tomatoes});
                myDbContext.SaveChanges();
            }
            List<PizzaModel> cart = SessionHelper.GetObjectFromJson<List<PizzaModel>>(HttpContext.Session, "cart");
            if (cart.Count == 1){
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", null);
            }
            else{
                cart.RemoveAt(IndexOf((int)id));
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            //А вот вы меня не ебите что я просто ~/ не сделал, оно сука тут не работает
            return Content($@"<!DOCTYPE html><html><head><meta charset=""utf-8""/></head><body><div style=""color:green;"">Заказ будет доставлен в течении 40 минут.</div> <a style=""display: block; margin-top: 10px;"" href=""{(Request.IsHttps ? Config.Domain.Insert(0, "https://") : Config.Domain.Insert(0, "http://"))}/Cart"">Вернуться</a></body></html>", "text/html");
        }

        [Route("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new Error { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier } );

        public int IndexOf(int id){
            
            List<PizzaModel> cart = SessionHelper.GetObjectFromJson<List<PizzaModel>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++){
                if (cart[i].Pizza.Id.Equals(id)){
                    return i;
                }
            }
            return -1;
        }

        [Route("AllPizzas/{id?}")]
        public IActionResult AllPizzas(string id){
            if (id is null || !new MyDbContext().AllPizzas.Any(x => x.CategoryName == id)) return RedirectToAction("Error");
            return View(new MyDbContext().AllPizzas.Where(x => x.CategoryName == id));
        }
    }
}