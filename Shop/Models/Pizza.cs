using ClassLibrary;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Shop
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public virtual Category<Pizza> Category { get; set; }
        public bool IsOnMainPage { get; set; }
        public int Price { get; set; }
        public virtual int CategoryId { get; set; }
        public string CategoryName { get; set; }   

        public Pizza() {}
        public Pizza(string name, string image, Category<Pizza> category, int price, bool isOnmainPage){
            Name = name;
            Image = image;
            Category = category;
            Price = price;
            IsOnMainPage = isOnmainPage;
        }
    }
}