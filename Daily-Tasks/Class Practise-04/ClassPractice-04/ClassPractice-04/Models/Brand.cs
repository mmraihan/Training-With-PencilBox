using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_04.Models
{
   public class Brand

    { 
        [Key]
        public int Brand_Id { get; set; }
        public string BrandName { get; set; }

        public ICollection<Item> Items { get; set; } // One to many. Brand has many items and item can have only one brand


    }
}
