using Class_3_AssociationRelation.Models;
using System;

namespace Class_3_AssociationRelation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Notes
            //Encapsulation
            //A language mechanism for restricting direct access to some of the object's components. (Access Modifies)
            /*A language construct that facilitates the bundling of data with the methods(or other functions) operating on that data
             creating a class and assign prop Frpm one class's property. 
            */
            #endregion



            Product product = new Product()
            {
                Code = "P001",
                Name = "Otobi Table",
                Price = 5500.99,
                ManufacturingDate = new DateTime(2021, 1, 1),
                         
            };
            Product product2 = new Product()
            {
                Code = "P002",
                Name = "Otobi Chair",
                Price = 8500.99,
                ManufacturingDate = new DateTime(2021, 1, 1),

            };

            //Category category = new Category()
            //{
            //    Name = "Furniture",
            //    Code = "Fur001"

            //};
            //product.ProductCategory = category;

            #region Category have Products

            Category aCategory = new Category();
            aCategory.Code = "ElecPro001";
            aCategory.Name = "Electronics";

            aCategory.Products.Add(product);
            aCategory.Products.Add(product2);
            aCategory.Products.Add(new Product()
            {
                Code= "ElecPro001",
                Name="TV",
                Price=897.0
            });

            string message = aCategory.ConsoleDisplay();
            Console.WriteLine(message);

            Console.ReadKey();
            #endregion





        }
    }

   
}
