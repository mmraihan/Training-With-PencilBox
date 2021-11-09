using Day_7_Insert_Update.Database;
using Day_7_Insert_Update.Models.EntityModels;
using System;

namespace Day_7_Insert_Update
{
    class Program
    {
        static void Main(string[] args)
        {
            Category category = new Category()
            {
                Name ="Furnitures"

            };
            Category category2 = new Category()
            {
                Name = "Electronics"
            };
            Category category3 = new Category()
            {
                Name = "Clothes"
            };

            SMECommerceDbContext db = new SMECommerceDbContext();

            db.Categories.Add(category);
            db.Categories.Add(category2); //Tracking all command
            db.Categories.Add(category3); //Tracking all command

            int successCount= db.SaveChanges(); //Finalyy hited in database

            if (successCount>0)
            {
                Console.WriteLine($"Data saved successfully. Success Count: {successCount}");
            }
            Console.ReadKey();
        }
    }
}
