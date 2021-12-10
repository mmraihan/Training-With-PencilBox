using Microsoft.AspNetCore.Mvc.Rendering;
using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Models.ProductModel
{
    public class ProductEditVm
    {    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ManufacturerDate { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public List<SelectListItem> Categoies { get; set; }

        //public Category Category { get; set; }
    }
}
