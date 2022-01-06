
using Microsoft.EntityFrameworkCore;
using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerce.Databases.DbContexts
{
    public class SMECommerceDbContext:DbContext
    {
        public SMECommerceDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Products { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionString = "Server=DESKTOP-4BMDG8B;Database=SMEDb;Trusted_Connection=True;MultipleActiveResultSets=True";
            //optionsBuilder
            //    //.UseLazyLoadingProxies()
            //    .UseSqlServer(connectionString);
                
        }
    }
}
