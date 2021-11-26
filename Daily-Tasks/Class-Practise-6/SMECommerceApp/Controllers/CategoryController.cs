using Microsoft.AspNetCore.Mvc;
using SMECommerceApp.Models.CategoryModel;
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
 
    
        public IActionResult Create(CategoryCreate categoryCreate)
        {
            if (categoryCreate.CategoryName!=null)
            {
                return View("Success");
            }
            return View();
        }
  
      


    }
}
