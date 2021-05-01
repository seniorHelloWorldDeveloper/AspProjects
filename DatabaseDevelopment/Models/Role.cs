using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DatabaseDevelopment.Models
{
    #pragma warning  disable CS0660, CS0661
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<User> Users { get; set; }
        public Role(){
            Users = new List<User>();
        }
        public static bool operator==(Role first, string Name) => 
            first.Id == new MyDbContext().Roles.FirstOrDefault(x => x.Name == Name).Id;
        
        public static bool operator!=(Role first, string Name) =>
            first.Id != new MyDbContext().Roles.FirstOrDefault(x => x.Name == Name).Id;
        
    }
}