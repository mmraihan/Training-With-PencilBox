using Day_8_Relationship.Database;
using Day_8_Relationship.Models.EntityModels;
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

            Console.WriteLine("Getting an oject");

            var id = int.Parse(Console.ReadLine());

            #region Read data by id
      
   
            var category = db.Categories.FirstOrDefault(c => c.Id == id);
          
            Console.WriteLine($"Category Details:  Id: {category.Id}, Name: {category.Name}");
            
            #endregion


            #region Update Data
           

            Console.WriteLine("Change the name to: ");

            string newName = Console.ReadLine();

            category.Name = newName;

            int successCount = db.SaveChanges();

            if (successCount>0)
            {
                Console.WriteLine($"Data Updated Successfully! Success Count {successCount}");
            }

       

            #endregion



         
            foreach (var item in categories)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
            }

            Console.ReadKey();
        }
    }
}
