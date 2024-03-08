namespace API.Models.DTO
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public Int16? UnitsInStock { get; set; }
    }
}
