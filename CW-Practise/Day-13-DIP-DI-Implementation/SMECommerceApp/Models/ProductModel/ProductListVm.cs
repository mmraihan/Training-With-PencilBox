using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Models.ProductModel
{
    public class ProductListVm
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Item> ProductList { get; set; }

    }
}
