using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using coffee_shop_mvc.Models;

namespace coffee_shop_mvc.Data
{
    public class CaffeeShopContext : DbContext
    {
        public CaffeeShopContext (DbContextOptions<CaffeeShopContext> options)
            : base(options)
        {
        }

        public DbSet<coffee_shop_mvc.Models.Product> Product { get; set; } = default!;
    }
}
