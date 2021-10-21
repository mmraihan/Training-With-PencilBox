using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Models
{
   public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SubCategory SubCategory { get; set; }
        public Type Type { get; set; }
        public Product Product { get; set; }
    }
}
