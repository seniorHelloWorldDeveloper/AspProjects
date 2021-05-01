using System.Collections.Generic;
using System.Linq;
using ClassLibrary;
using Microsoft.EntityFrameworkCore;

namespace Shop
{
    public class DatabaseObjects
    {
        private static IReadOnlyDictionary<string, Category<Pizza>> Categories { get; } = new Dictionary<string, Category<Pizza>>() {
            {"Мясные", new Category<Pizza>() {Name = "Мясные"}},
            {"Вегетарианские", new Category<Pizza>() {Name = "Вегетарианские"}},
        };
        private static List<Pizza> _allPizzas { get; } = new List<Pizza>()
        {
            new Pizza("Пепперони", "https://static.pizzasushiwok.ru/images/menu_new/6-1300.jpg", Categories["Мясные"], 325, true) { CategoryName = "Мясные" },
            new Pizza("Пицца с грибами", "https://static.pizzasushiwok.ru/images/menu_new/6-1300.jpg", Categories["Мясные"], 500, true) { CategoryName = "Мясные" },
            new Pizza("Маргарита", "https://image.freepik.com/free-photo/pizza-margarita-isolated-on-white-background_143106-161.jpg", Categories["Вегетарианские"], 400, true) { CategoryName = "Вегетарианские" }
        };
        
        private IReadOnlyCollection<Pizza> AllPizzas {
            get{
                
                foreach (Pizza elem in _allPizzas){
                    if (!elem.Category.Elements.Contains(elem)){
                        elem.Category.Elements.Add(elem);
                    }
                }
                return _allPizzas;
            }
        }
        public void Insert(){
            using (MyDbContext myDbContext = new MyDbContext()){
                bool t1 = false, t2 = false;
                foreach (var elem in Categories){
                    if (!myDbContext.AllCategories.Any(x => x.Name == elem.Value.Name)){
                        t1 = true;
                        myDbContext.AllCategories.Add(elem.Value);
                    }
                }

                foreach (var elem in AllPizzas){
                    if (!myDbContext.AllPizzas.Any(x => x.Name == elem.Name)){
                        t2 = true;
                        myDbContext.AllPizzas.Add(elem);
                    }
                }
                System.Console.WriteLine(t1.ToString() + ", " + t2.ToString());
                if (t1 || t2){
                    myDbContext.SaveChanges();
                }
                if (myDbContext.AllPizzas.Any(x => x.Image == "https://static.pizzasushiwok.ru/images/menu_new/6-1300.jpg")){
                    Pizza pizza = myDbContext.AllPizzas.FirstOrDefault(x => x.Image == "https://static.pizzasushiwok.ru/images/menu_new/6-1300.jpg");
                    pizza.Image = "https://image.freepik.com/free-photo/pizza-margarita-isolated-on-white-background_143106-161.jpg";
                    myDbContext.SaveChanges();
                }
            }
        }
    }
}