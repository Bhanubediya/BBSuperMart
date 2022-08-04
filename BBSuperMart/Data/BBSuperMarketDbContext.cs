using BBSuperMart.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBSuperMart.Data
{
    public class BBSuperMarketDbContext: IdentityDbContext
    {

        
        public BBSuperMarketDbContext(DbContextOptions<BBSuperMarketDbContext>options):base(options)
        {
            
        }

        
        public DbSet<Category> Category { get; set; }

        public DbSet<Products> Products { get; set; }

    public  DbSet<ApplicationUser> ApplicationUser { get; set; }

    }
}
