using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3_AssociationRelation.Models
{
    public class Product
    {
        public Product()
        {
            ProductCategory = new Category();
        }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }

        //Creating Encapsulation process by creating another class and assignt these propertise
        //public string Category { get; set; }  
        //public string CategoryCode { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public Category ProductCategory { get; set; }


        public string GetConsoleDisplay()
        {
            string message = "";
            message += "Product Name: " + Name + Environment.NewLine;
            message += "Product Code: " +Code + Environment.NewLine;
            message += "Product Price: " +Price + Environment.NewLine;

            return message;
        }
    }
}
