using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Models.Models
{
    public class Product
    {
        public Product()
        {
            ProductCategory = new Category();
        }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public bool IsAvailable { get; set; }

        public Category ProductCategory { get; set; }

        public string GetProductInfo()
        {
            string info= $"Product Id: {ProductId}, Product Name: {Title}, Dtails: {Details}, Price: {Price}, " +
                         $"Image: {ImagePath}, IsAvailable: {IsAvailable} \n";
            return info;

        }
       



    }
}
