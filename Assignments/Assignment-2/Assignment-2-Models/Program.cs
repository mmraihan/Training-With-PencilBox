using Assignment_2_Models.Models;
using System;
using System.Collections.Generic;

namespace Assignment_2_Models
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object of Products
            var appleProduct = new Product()
            {
                ProductId = 01,
                Title = "Apple",
                Details = "Apples are some of the most popular fruits on the planet",
                Price = 219,
                IsAvailable = true,
                ImagePath = "url"
            };

            var watermelonProduct = new Product()
            {
                ProductId = 02,
                Title = "Watermelon",
                Details = "Watermelon are some of the most popularfruits",
                Price = 469,
                IsAvailable = true,
                ImagePath = "url"
            };

            var mangoProduct = new Product()
            {
                ProductId = 02,
                Title = "Mango",
                Details = "Watermelon are some of the most popular and delicious fruits on the planet",
                Price = 0,
                IsAvailable = false,
                ImagePath = "url"
            };
            #endregion


            #region One To Many RealionShip


            var categoy = new Category();
            categoy.CategoryId = 001;
            categoy.CategoryName = "Food";
            categoy.Products.Add(appleProduct);
            categoy.Products.Add(watermelonProduct);
            categoy.Products.Add(mangoProduct);

            string result = categoy.GetCategoryInfo();
           
            Console.WriteLine(result);
            #endregion

            Console.ReadKey();



        }
    }
}
