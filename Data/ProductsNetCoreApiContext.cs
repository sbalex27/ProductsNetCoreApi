using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductsNetCoreApi.Models;

namespace ProductsNetCoreApi.Data
{
    public class ProductsNetCoreApiContext : DbContext
    {
        public ProductsNetCoreApiContext (DbContextOptions<ProductsNetCoreApiContext> options)
            : base(options)
        {
        }

        public DbSet<Product>? Product { get; set; }
        public DbSet<Brand>? Brand { get; set; }
        public DbSet<Category?> Category { get; set; }
        public DbSet<ProductsNetCoreApi.Models.Category>? Category_1 { get; set; }
    }
}
