using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SMECommerce.Services.Abstractions;
using SMECommerceApp.Models.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Controllers.API
{
    [Route("api/[controller]")]
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
    }
}
