using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using coffee_shop_mvc.Models;

namespace coffee_shop_mvc.Data
{
    public class CoffeeShopContext : DbContext
    {
        public CoffeeShopContext (DbContextOptions<CoffeeShopContext> options)
            : base(options)
        {
        }

        public DbSet<coffee_shop_mvc.Models.Product> Product { get; set; } = default!;
        public DbSet<coffee_shop_mvc.Models.Order> Order { get; set; } = default!;
        public DbSet<coffee_shop_mvc.Models.OrderProduct> OrderProduct { get; set; } = default!;
    }
}
