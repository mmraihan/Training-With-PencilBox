using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewBagDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewData["name"] = "I am from ViewData";
            ViewData["names"] = new List<string>()
            {
                "Mahin","Raihan","Sahik"
            };




            return View();
        }
    }
}
