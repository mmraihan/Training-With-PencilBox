using Microsoft.AspNetCore.Mvc;
using SMECommerceApp.Models.CatgoryModel;
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
            return "Welcome to Category Controller";
        }

        public string Create(Category category)
        {
            return $"Category Id {category.Id}, Category Name: {category.CategoryName}";
        }


    }
}
