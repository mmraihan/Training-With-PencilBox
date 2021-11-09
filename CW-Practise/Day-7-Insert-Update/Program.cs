using Day_7_Insert_Update.Database;
using Day_7_Insert_Update.Models.EntityModels;
using System;
using System.Linq;

namespace Day_7_Insert_Update
{
    class Program
    {
        static void Main(string[] args)
        {
            SMECommerceDbContext db = new SMECommerceDbContext();


            #region Inser Data

            /*
            var categories = new[]
          {
                new Category(){Name="Sports"},
                new Category(){Name="Foods"},
                new Category(){Name="Shoes"},
                new Category(){Name="Vegetables"},
            };


            db.Categories.AddRange(categories);    //Tracking all command

            int successCount = db.SaveChanges(); //Finalyy hited in database

            if (successCount > 0)
            {
                Console.WriteLine($"Data saved successfully. Success Count: {successCount}");
            }

            */
            #endregion


            #region Read Data

            var categories = db.Categories;
            int i = 0;
            foreach (var item in categories)
            {
                Console.WriteLine($"S/N: {++i},  Id: {item.Id}, Name: {item.Name}");
            }


            #endregion

          

            #region Read data by id
            Console.WriteLine("Getting an oject");

            var id = int.Parse(Console.ReadLine());


            var category = db.Categories.FirstOrDefault(c => c.Id == id);
            Console.WriteLine($"Category Details:  Id: {category.Id}, Name: {category.Name}");
            #endregion


            #region Update Data

            #endregion

            Console.ReadKey();
        }
    }
}
