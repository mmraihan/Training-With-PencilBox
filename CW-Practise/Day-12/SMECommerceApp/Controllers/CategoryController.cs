using Microsoft.AspNetCore.Mvc;
using SMECommerce.Databases.DbContexts;
using SMECommerce.Models.EntityModels;
using SMECommerce.Repositories;
using SMECommerceApp.Models.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryRepository _categoryRepository;
        public CategoryController()
        {
            _categoryRepository = new CategoryRepository();
        }

        public string Index()
        {
            return "Welcome to Category Controller";
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryCreate categoryCreate)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            if (categoryCreate.Name!=null)
            {
                var category = new Category()
                {
                    Name = categoryCreate.Name,
                    Code=categoryCreate.Code,
                    Description = categoryCreate.Description,

                };
                var isAdded = categoryRepository.Add(category);
                if (isAdded)
                {
                    return View("Success");
                }
            }
            return View();
        }

        public IActionResult List()
        {
            var listOfCategoy = _categoryRepository.GetAll();

            #region Send data to View via ViewBag (loosely typed)
  
            ViewBag.listOfCategory = listOfCategoy;

            #endregion

            #region passing data to View via ViewData (loosely typed)

            ViewData["categoryList"] = listOfCategoy;

            #endregion


            return View();
          


        }
  
    }
}
