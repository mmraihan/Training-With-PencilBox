using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMECommerce.Models.EntityModels;
using SMECommerce.Services.Abstractions;
using SMECommerceApp.Models.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Controllers.API
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;



        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes ="Bearer")] //By Default Cookies
        public IActionResult GetCategories()
        {

            var objFromDb = _categoryService.GetAll();
           
            if (objFromDb==null)
            {
                return NoContent();
            }

            var categoryResults = _mapper.Map<IList<CategoryResultVM>>(objFromDb);
            return Ok(categoryResults);
                                       
        }

        [HttpGet("{id}")] //id= placeholder and should be same (equivalent to method parameter) for action binding.
        public IActionResult GetById(int? id) //receive that id as an argument
        {
            if (id==null)
            {
                return BadRequest("Provide an Id");
            }
            var objFromDb = _categoryService.GetById((int)id);
            if (objFromDb==null)
            {
                return NotFound();
            }
            var category = _mapper.Map<CategoryResultVM>(objFromDb);
            return Ok(category);
            
        }


        [HttpPost]
        public IActionResult Post([FromBody]CategoryCreate model)
        {
            if (ModelState.IsValid)
            {
               
                var data = _mapper.Map<Category>(model);

                var isSuccess = _categoryService.Add(data);
                if (isSuccess)
                {
                    return Created($"api/categories/{data.Id}", data);
                }
                
            }
            return BadRequest(ModelState);
        }


       [HttpPut("{id}")]
       public IActionResult Put(int? id , [FromBody]CategoryEditVM model)
        {
            if (id==null)
            {
                return BadRequest("Please Provide id");
            }

            var categoryFromObj = _categoryService.GetById((int)id);
            if (categoryFromObj==null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _mapper.Map(model, categoryFromObj); //Passing model to categoryFromObj

                bool isSuccess = _categoryService.Update(categoryFromObj);
                if (isSuccess)
                {
                    return Ok(categoryFromObj);
                }
            }

            return BadRequest(ModelState);
          
        }
        

        [HttpDelete("{id}")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var objFromDb = _categoryService.GetById((int)id);
            bool isSuccess = _categoryService.Remove(objFromDb);
            if (isSuccess)
            {
                return Ok("Successfully Deleted");
            }
            return BadRequest();
        }
    }
}
