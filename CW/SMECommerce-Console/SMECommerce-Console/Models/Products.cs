using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerce_Console.Models
{
    //shirajul.mamun@gmail.com
    //pomodoro- Marinara
    // microsot todo

    //class 4

    // inheritence bards
    //up castng

    // Design Pattern Book Name: Head First Design Patterns

    public class Product
    {
        string code;
        string name;
        double price;
        string brand;
        string type;
        string category;
        string categoryCode;


        //Using Constructor


        private Product(string code, string name)
        {
            this.code = code;
            this.name = name;
         
        }
       private Product(string code, string name, double price) : this(code,name)
        { 
            this.price = price;
        }

        public Product(string code, string name, double price, string brand) :this(code,name,price)
        {
            this.brand = brand;
        }

        public string GetInfo()
        {
            return $"{code}, {name}, {price}, {brand}";
        }


        //Using method setter getter
        public void SetCode(string code)
        {
            this.code = code;
        }
        public string GetCode()
        {
            return this.code;
        }



    }

}
