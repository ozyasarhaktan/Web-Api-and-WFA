using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}
