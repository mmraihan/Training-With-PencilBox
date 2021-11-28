using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Models.CategoryModel
{
    public class CategoryListVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Category> CategorieList { get; set; }

    }
}
