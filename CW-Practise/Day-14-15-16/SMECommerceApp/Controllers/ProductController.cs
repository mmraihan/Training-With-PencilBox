using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMECommerce.Models.EntityModels;
using SMECommerce.Repositories;
using SMECommerce.Services.Abstractions;
using SMECommerceApp.Models.ProductModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Controllers
{
    public class ProductController : Controller
    {       

        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(IProductService productService, ICategoryService categoryService, IWebHostEnvironment webHostEnvironment)
        {
            _productService = productService;
            _categoryService = categoryService;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

      [Authorize]
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
            var categories = _categoryService.GetAll().Select(c => new SelectListItem
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
            if (model.Photo!=null)
            {
                var webRootPath = _webHostEnvironment.WebRootPath;
                var upLoadPath = Path.Combine(webRootPath, @"images\products");
                var extension = Path.GetExtension(model.Photo.FileName);
                var fileName = Guid.NewGuid().ToString();

                using (var fileStream = new FileStream(Path.Combine(upLoadPath,fileName+extension), FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }


                Item item = new Item()
                {
                    Name = model.Name,
                    Description = model.Description,
                    ManufacturerDate = model.ManufacturerDate,
                    Price = model.Price,
                    CategoryId=model.CategoryId,
                    ImagePath= @"images\products\"+fileName+extension
                };

                var isAdded = _productService.Add(item);
                if (isAdded)
                {
                    return RedirectToAction("List");
                }
            }

            return View();
        }

        [Authorize]
        public IActionResult List()
        {
            var productList = _productService.GetAll(); //Received data from Database for passing to User

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
            var product = _productService.GetById((int)id);

            var categories = _categoryService.GetAll();

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
                bool isUpdated = _productService.Update(item);
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
            var product = _productService.GetById((int)id);
            if (product==null)
            {
                return RedirectToAction("List");
            }

            bool isRemoved= _productService.Remove(product);

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

            var product = _productService.GetById((int)id);
            
          
            var catName = _categoryService.CategoryName((int)product.CategoryId);

            var productDetailsVm = new ProductDetailsVm()

            {
                Name = product.Name,
                Price = product.Price,
                ManufactererDate = product.ManufacturerDate,
                Description = product.Description,
                CategoryId=(int)product.CategoryId,
                CategoryName=catName.Name,
                Photo=@"\"+ product.ImagePath
             
            };

           
            return View(productDetailsVm);

        }

    }
}
