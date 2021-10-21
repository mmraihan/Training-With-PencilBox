using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Models.Models
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; private set; }

        public string GetCategoryInfo()
        {
           
           
           string message= $"Category Id: {CategoryId}, Category Code: {CategoryName}\n \n";

            foreach (var product in Products)
            {
                message += product.GetProductInfo() + "\n";
            }
            return message;

        }
    }
}
