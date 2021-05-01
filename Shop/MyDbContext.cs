using System.ComponentModel.DataAnnotations.Schema;
using ClassLibrary;
using Microsoft.EntityFrameworkCore;
using Shop.Models;
namespace Shop
{
    public class MyDbContext : DbContext
    {
        public DbSet<Category<Pizza>> AllCategories { get; set; }
        public DbSet<Pizza> AllPizzas { get; set; }
        public DbSet<Order> AllOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Pizzas;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}