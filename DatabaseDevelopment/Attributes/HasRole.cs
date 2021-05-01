using System.ComponentModel.DataAnnotations;
using DatabaseDevelopment.Models;
using System.Threading.Tasks;
using ClassLibrary.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using DatabaseDevelopment.Controllers;
using System.Linq;

namespace DatabaseDevelopment.Attributes
{
    public class HasRole : Attribute
    {
        public string RoleName { get; }

        public HasRole(string roleName)
        {
            RoleName = roleName;
        }

        public bool IsValid(User user, string roleName)
        {
            if (user is null){
                return false;
            }
            var userRole = new MyDbContext().Roles.First(x => x.Id == user.Id);
            return userRole == roleName;
        }
    }
}