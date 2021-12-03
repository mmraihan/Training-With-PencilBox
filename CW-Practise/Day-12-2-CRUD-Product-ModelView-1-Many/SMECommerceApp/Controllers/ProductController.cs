using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMECommerce.Models.EntityModels;
using SMECommerce.Repositories;
using SMECommerceApp.Models.ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Controllers
{
    public class ProductController : Controller
    {       

        private readonly ProductRepository _productRepository;
        private readonly CategoryRepository _categoryRepository;
        public ProductController()
        {
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {

            #region Approach-1- Select Drop-Down
            //var categories = _categoryRepository.GetAll();

            //var cList = new List<SelectListItem>();
            //foreach (var item in categories)
            //{
            //    cList.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.Name });
            //}


            //var vm = new ProductCreateVm()
            //{
            //    Categoies = cList
            //};

            //return View(vm);
            #endregion

            #region Approach-2 - Select Drop-Down
            var categories = _categoryRepository.GetAll().Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name

            }); ;
            var vm = new ProductCreateVm();
            vm.SelectCategoies = categories.ToList();

            return View(vm);
            #endregion

        }

        [HttpPost]
        public IActionResult Create(ProductCreateVm model)//Received data from user for inserting at Database
        {
            if (model.Name!=null)
            {
                Item item = new Item()
                {
                    Name = model.Name,
                    Description = model.Description,
                    ManufacturerDate = model.ManufacturerDate,
                    Price = model.Price,
                    CategoryId=model.CategoryId
                };

                var isAdded = _productRepository.Add(item);
                if (isAdded)
                {
                    return RedirectToAction("List");
                }
            }

            return View();
        }

        public IActionResult List()
        {
            var productList = _productRepository.GetAll(); //Received data from Database for passing to User

            var productListVm = new ProductListVm()
            {
               Title="Product Overview",
               Description="You can create,update and delete product from here.",
               ProductList=productList
              
            };

            return View(productListVm);
        }


        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("Edit");
            }
            var product = _productRepository.GetById((int)id);

            var categories = _categoryRepository.GetAll();

            var cList = new List<SelectListItem>();
            foreach (var item in categories)
            {
                cList.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.Name });
            }


            

            var productEditVm = new ProductEditVm()
            {
                Id=product.Id,
                Name=product.Name,
                Description=product.Description,
                ManufacturerDate=product.ManufacturerDate,
                Price=product.Price,
                CategoryId=(int)product.CategoryId,
                Categoies=cList
              
            };
            return View(productEditVm);
        }

        [HttpPost]
        public IActionResult Edit(ProductEditVm model)
        {
            if (ModelState.IsValid)
            {
                var item = new Item()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Description = model.Description,
                    Price = model.Price,
                    ManufacturerDate = model.ManufacturerDate,
                    CategoryId=model.CategoryId
                    
                };
                bool isUpdated = _productRepository.Update(item);
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
            var product = _productRepository.GetById((int)id);
            if (product==null)
            {
                return RedirectToAction("List");
            }

            bool isRemoved=_productRepository.Remove(product);

            if (isRemoved)
            {
                return RedirectToAction("List");
            }
            return RedirectToAction("List");

        }


        public IActionResult Details(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("List");
            }

            var product = _productRepository.GetById((int)id);
            
          
            var catName = _categoryRepository.CategoryName((int)product.CategoryId);

            var productDetailsVm = new ProductDetailsVm()

            {
                Name = product.Name,
                Price = product.Price,
                ManufactererDate = product.ManufacturerDate,
                Description = product.Description,
                CategoryId=(int)product.CategoryId,
                CategoryName=catName.Name
             
            };

           
            return View(productDetailsVm);

        }

    }
}
