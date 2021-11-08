using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Task.Models
{
   public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public DateTime ManufactureDate { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}
