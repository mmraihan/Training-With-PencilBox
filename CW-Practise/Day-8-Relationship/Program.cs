using Day_8_Relationship.Database;
using Day_8_Relationship.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_7_Insert_Update
{
    class Program
    {
        static void Main(string[] args)
        {
            SMECommerceDbContext db = new SMECommerceDbContext();


            #region Inser Data

            var cateory = new Category()
            {
                Name="Furniture"
            };


            var items = new List<Item>()
            {
                new Item()
                {
                    Name="Chair",
                    Price=6500,
                    ManufacturerDate=DateTime.Now
                },

                 new Item()
                {
                    Name="Table",
                    Price=4500,
                    ManufacturerDate=DateTime.Now
                 },

                  new Item()
                {
                    Name="Bed",
                    Price=9500,
                    ManufacturerDate=DateTime.Now
                  },

            };


            cateory.Items = items;

            db.Categories.Add(cateory);

            int successCount = db.SaveChanges(); 

            if (successCount > 0)
            {
                Console.WriteLine($"Data saved successfully. Success Count: {successCount}");
            }


            #endregion




            #region Read data by id


            /*
             * var category = db.Categories.FirstOrDefault(c => c.Id == id);

             Console.WriteLine($"Category Details:  Id: {category.Id}, Name: {category.Name}");
             */
            #endregion


            #region Update Data

            /*
            Console.WriteLine("Change the name to: ");

            string newName = Console.ReadLine();

            category.Name = newName;

            int successCount = db.SaveChanges();

            if (successCount>0)
            {
                Console.WriteLine($"Data Updated Successfully! Success Count {successCount}");
            }

       
            */
            #endregion

            #region Read Data


            var categories = db.Categories;

            foreach (var item in categories)
            {
                Console.WriteLine($"Id: {item.Id}, Category Name: {item.Name}");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
