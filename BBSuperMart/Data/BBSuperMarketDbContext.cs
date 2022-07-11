using BBSuperMart.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBSuperMart.Data
{
    public class BBSuperMarketDbContext: DbContext
    {
        
        public BBSuperMarketDbContext(DbContextOptions<BBSuperMarketDbContext>options):base(options)
        {
            
        }

        
        public DbSet<Category> Category { get; set; }

        public DbSet<Products> Products { get; set; }

    }
}
