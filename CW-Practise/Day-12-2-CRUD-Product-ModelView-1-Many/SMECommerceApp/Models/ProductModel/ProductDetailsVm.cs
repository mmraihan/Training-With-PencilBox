using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Models.ProductModel
{
    public class ProductDetailsVm
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ManufactererDate { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }


    }
}
