using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Product.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        public DbSet<ProductItem> Products { get; set; } // DbSet cho sản phẩm
    }
}
