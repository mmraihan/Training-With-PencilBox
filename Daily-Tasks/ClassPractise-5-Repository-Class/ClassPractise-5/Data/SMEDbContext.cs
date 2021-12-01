using ClassPractise_5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractise_5.Data
{
    public class SMEDbContext : DbContext
    {
  
        public DbSet<Item> Items { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=DESKTOP-4BMDG8B;Database=ClassPractise-5Db;Trusted_Connection=True;MultipleActiveResultSets=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
