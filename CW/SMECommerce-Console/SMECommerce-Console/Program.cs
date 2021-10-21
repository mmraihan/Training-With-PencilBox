using SMECommerce_Console.Models;
using System;

namespace SMECommerce_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Notes
            //Constructor design should be biiger to smaller
            //Design Pattern

            #endregion

            Product product = new Product("P-01", "Ram-8GB", 3500, "G-Skill");
            var output=product.GetInfo();
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
