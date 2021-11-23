using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewBagDemo.Models;

namespace ViewBagDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            #region ViewData
            ViewData["name"] = "I am from ViewData";
            ViewData["names"] = new List<string>()
            {
                "Mahin","Raihan","Sahik"
            };
            #endregion


            #region BiewData from model

            Product product = new Product()
            {
                Id = "101",
                Name = "Laptop",
                Category = "Electronics"
            };
               ViewData["prpductName"] = product;

            #endregion


            return View();
        }
    }
}
