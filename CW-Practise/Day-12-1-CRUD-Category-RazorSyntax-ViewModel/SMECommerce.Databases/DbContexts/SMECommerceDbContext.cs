
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
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Products { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(local);Database=Day11TaskSMECommerceDB;Integrated Security=true";
            optionsBuilder
                //.UseLazyLoadingProxies()
                .UseSqlServer(connectionString);
                
        }
    }
}
