using System.Collections.Generic;

namespace Shop.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public Pizza Pizza { get; set; }
        public int Centimeters { get; set; }
        public bool Meat { get; set; }
        public bool Onion { get; set; }
        public bool Tomatoes { get; set; }
        public int Amount { get; set; }
    }
}