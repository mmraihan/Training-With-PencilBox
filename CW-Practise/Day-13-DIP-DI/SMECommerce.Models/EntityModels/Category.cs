using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerce.Models.EntityModels
{
    public class Category
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public ICollection<Item> Items { get; set; }
        
    }
}
