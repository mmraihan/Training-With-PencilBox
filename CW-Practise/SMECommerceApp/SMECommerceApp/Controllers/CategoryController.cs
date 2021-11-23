using Microsoft.AspNetCore.Mvc;
using SMECommerceApp.Models.CategoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Controllers
{
    public class CategoryController : Controller
    {
        public string Index()
        {
            return "This is the default Controller";
        }

        public string Create(CategoryCreate category)
        {
            return $"Category Create--- Name: {category.Name}, Code: {category.Code}";
        }
        #region Enter this link to url
        //https://localhost:44397/category/CategoryListCreate?
        //categories[0].name=Furniture&categories[0].code=101&categories[1].name=Electronics&categories[1].code=102
        #endregion
        //List Binding
        public string CategoryListCreate(CategoryCreate[] categories)
        {

            string data = "Category List Create "+ Environment.NewLine;
            if (categories!=null && categories.Any())
            {
                foreach (var category in categories)
                {
                  data+= $"Category Create--- Name: {category.Name}, Code: {category.Code}" + Environment.NewLine;
                }
            }

            return data;
              
        }


    }
}
