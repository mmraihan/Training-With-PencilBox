﻿using Microsoft.AspNetCore.Mvc;
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
           // CategoryRepository categoryRepository = new CategoryRepository();
            if (categoryCreate.Name!=null)
            {
                var category = new Category()
                {
                    Name = categoryCreate.Name,
                    Code=categoryCreate.Code,
                    Description = categoryCreate.Description,

                };
                var isAdded = _categoryRepository.Add(category);
                if (isAdded)
                {
                    return RedirectToAction("List");
                    //return View("List");
                }
            }
            return View();
        }

        public IActionResult List()
        {
            var listOfCategoy = _categoryRepository.GetAll();

            #region Send data to View via ViewBag (Weakly typed)

            //ViewBag.listOfCategory = listOfCategoy;

            #endregion

            #region passing data to View via ViewData (Weakly typed)

            //ViewData["categoryList"] = listOfCategoy;

            #endregion

            #region passing data to View via Model (Strongly Typed)


            //return View(listOfCategoy);
            #endregion

            #region passing data to View via View Model (Strongly Typed with related data)
            var categoryListVm = new CategoryListVM()
            {
                Title = "Category Overview",
                Description = "You can create,update and delete data from here.",
                CategorieList = listOfCategoy

            };
            return View(categoryListVm);
          
            #endregion

        }

        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("List");
            }

            var category = _categoryRepository.GetById((int)id);
            if (category==null)
            {
                return RedirectToAction("List");
            }
            var categoryEditVm = new CategoryEditVM()
            {
               Id=category.Id,
               Name=category.Name,
               Code=category.Code,
               Description=category.Description
            };

            return View(categoryEditVm);
        }

        [HttpPost]
        public IActionResult Edit(CategoryEditVM model)
        {
            if (ModelState.IsValid)
            {
                var category = new Category()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Code = model.Code,
                    Description = model.Description
                };

               bool isUpdated= _categoryRepository.Update(category);
                if (isUpdated)
                {
                    return RedirectToAction("List");
                }

            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("List");
            }
            var category = _categoryRepository.GetById((int)id);

            if (category==null)
            {
                return RedirectToAction("List");
            }

            bool isRemoved=_categoryRepository.Remove(category);
            if (isRemoved)
            {
                return RedirectToAction("List");
            }
            return RedirectToAction("List");       
        }
    }
}
