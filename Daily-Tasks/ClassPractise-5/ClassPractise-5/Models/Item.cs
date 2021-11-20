using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractise_5.Models
{
    public class Item
    {
        [Key]
        public int Item_Id { get; set; }
        public string Name { get; set; }
        public DateTime ManufacturerDate { get; set; }
        public double Price { get; set; }

      


        // One to many. Brand has many items and item can have only one brand

        [ForeignKey("Brand")]
        public int Brand_Id { get; set; }
        public Brand Brand { get; set; }
    }
}
