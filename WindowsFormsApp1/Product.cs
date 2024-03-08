using Newtonsoft.Json.Linq;
using System;

namespace API.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public System.Int16? UnitsInStock { get; set; }

    }
}
