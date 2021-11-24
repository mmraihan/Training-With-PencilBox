using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewBagDemo.Models;

namespace ViewBagDemo.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(FormEmployee formEmployee)
        {
            return $"{formEmployee.Name}, {formEmployee.Gender}, {formEmployee.Married}";
        }



    }
}
