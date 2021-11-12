using Day_8_Relationship.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Relationship.Database
{
     public class SMECommerceDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=DESKTOP-4BMDG8B;Database=SMECommerceDb;Trusted_Connection=True;MultipleActiveResultSets=True";
            optionsBuilder.UseSqlServer (connectionString);
        }


    }
}
