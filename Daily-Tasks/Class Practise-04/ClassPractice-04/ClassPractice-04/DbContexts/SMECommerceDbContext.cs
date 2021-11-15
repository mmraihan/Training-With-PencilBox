using ClassPractice_04.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_04.DbContexts
{

    public class SMECommerceDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=DESKTOP-4BMDG8B;Database=Day8TaskSMECommerceDb;Trusted_Connection=True;MultipleActiveResultSets=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
