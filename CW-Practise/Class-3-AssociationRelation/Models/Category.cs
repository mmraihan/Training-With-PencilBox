using System;
using System.Collections.Generic;

namespace Class_3_AssociationRelation.Models
{
    public class Category
    {

        public Category()
        {
            Products = new List<Product>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; private set; }



        public string ConsoleDisplay()
        {
            string message = "";
            message += "Catgegory Code: " + Code + Environment.NewLine;
            message += "Catgegory Name: " + Name + Environment.NewLine;

            message += "Product Information of Category......" + Environment.NewLine;

            foreach (Product p in Products)
            {
                message += p.GetConsoleDisplay();
                message += "-------------------------------------------------" + Environment.NewLine;

            }

            return message;
        }
    }



}
