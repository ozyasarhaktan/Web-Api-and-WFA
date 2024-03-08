using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class Product
    {
        public int ProductID { get; set; }   //4
        public string ProductName { get; set; } //a -> b
        public decimal? UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public Int16? UnitsInStock { get; set; }
        public Int16? UnitsOnOrder { get; set; }
        public Int16? ReOrderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
