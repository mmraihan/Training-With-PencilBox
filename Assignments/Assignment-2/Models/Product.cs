using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double SellingQuantity { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public string Image { get; set; }
        public double Discount { get; set; }

        public List<string> ListOfImages { get; set; }

        public Type Type { get; set; }
        public SubCategory SubCategory { get; set; }
        public Category Category { get; set; }



    }
}
