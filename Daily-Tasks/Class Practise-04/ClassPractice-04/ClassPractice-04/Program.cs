using ClassPractice_04.DbContexts;
using ClassPractice_04.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassPractice_04
{
    class Program
    {

   
        static void Main(string[] args)
        {
            var db = new SMECommerceDbContext();

            #region All Items
            var item = new List<Item>()
            {
                new Item()
                {
                    Name="Table",
                    Price=4000,
                    ManufacturerDate=DateTime.Now



                },
                new Item()
                {
                    Name="Chair",
                    Price=2500,
                    ManufacturerDate=DateTime.Now

                },

                new Item()
                {
                    Name="Almeera",
                    Price=22550,
                    ManufacturerDate=DateTime.Now
                }

            };

            var item2 = new List<Item>()
            {
                new Item()
                {
                    Name="ProBook Laptop",
                    Price=124000,
                    ManufacturerDate=DateTime.Now



                },
                new Item()
                {
                    Name="Keyboard",
                    Price=950,
                    ManufacturerDate=DateTime.Now

                },

                new Item()
                {
                    Name="Mouse",
                    Price=550,
                    ManufacturerDate=DateTime.Now
                }

            };


            #endregion

            #region All Brands

            var listOfbrands = new List<Brand>()
            {
                new Brand() { BrandName = "Otobi", Items = item},
                new Brand() { BrandName = "Asus", Items = item2},

            };

            #endregion


            #region Insert Data one to many
            db.Brands.AddRange(listOfbrands);

            int successCount = db.SaveChanges();

            if (successCount > 0)
            {
                Console.WriteLine($"Data saved successfully. Success Count: {successCount}");
            }
            #endregion



            #region Read Data One to Many RelationShip

            var brands = db.Brands;
            foreach (var b in brands)
            {
                Console.WriteLine($"Brand Id: {b.Brand_Id}, Brand Name: {b.BrandName}");

                Console.WriteLine($"-------------Items of Brand: {b.BrandName}-------------------");
                foreach (var i in b.Items)
                {
                    Console.WriteLine($"Name: {i.Name}, Price: {i.Price}, Date: {i.ManufacturerDate}");
                }
            }
            #endregion




            Console.ReadKey();

        }
    }
}
