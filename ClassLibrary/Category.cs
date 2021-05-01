using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ClassLibrary.Helpers;

namespace ClassLibrary
{
    public class Category<T> where T: class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<T> Elements { get; set; }

        public Category(){
            Elements = new HashSet<T>();
        }
    }
}