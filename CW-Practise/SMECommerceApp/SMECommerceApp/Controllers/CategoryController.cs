using Microsoft.AspNetCore.Mvc;
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

        public string Create(string name, int code)
        {
            return $"Category Create--- Name: {name}, Code: {code}";
        }


    }
}
