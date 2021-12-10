using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerce.Models.EntityModels
{
    [Table("Products")]
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ManufacturerDate { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        // public Brand Brand { get; set; }

        // public int? BrandId { get; set; }

        public string ImagePath { get; set; }


    }
}
