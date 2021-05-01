using DatabaseDevelopment.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseDevelopment
{
    public class MyDbContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DatabaseDevelopment;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder){
            Role amdinRole = new Role { Id = 1, Name = "admin" };
            Role userRole = new Role { Id = 2, Name = "user" };
            User amdin = new User { Id = 1, Login = "Admin", Password = "root", RoleId = 1 };
            builder.Entity<Role>().HasData(new Role[] { amdinRole, userRole });
            builder.Entity<User>().HasData(new User[] { amdin });
            
            base.OnModelCreating(builder);
        }
    }
}