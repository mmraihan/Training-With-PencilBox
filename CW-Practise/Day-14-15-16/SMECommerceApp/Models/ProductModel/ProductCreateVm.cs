using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Models.ProductModel
{
    public class ProductCreateVm
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ManufacturerDate { get; set; }
        public decimal Price { get; set; }

        //-------Select Drop-Down-------------
        [Required]
        public int CategoryId { get; set; }
        public List<SelectListItem> SelectCategoies { get; set; }

        //---------Image----------------

        [Required]
        public IFormFile Photo { get; set; }


    }
}
