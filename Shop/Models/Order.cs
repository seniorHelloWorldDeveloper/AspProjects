namespace Shop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Adress { get; set; } 
        public string Telephone { get; set; }
        public string PizzaName { get; set; }
        public bool Meat { get; set; }
        public bool Onion { get; set; }
        public bool Tomatoes { get; set; }

    }
}