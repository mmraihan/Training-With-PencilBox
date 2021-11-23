using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewBagDemo.Models;

namespace ViewBagDemo.Controllers
{
    public class ViewBagController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Hello I am from ViewBag";

            Product productOfViewbag = new Product()
            {
                Id = "KeyBoard-101",
                Name = "Keyboard",
                Category="Electronics"
            };

            ViewBag.p = productOfViewbag;

            return View();
        }
    }
}
