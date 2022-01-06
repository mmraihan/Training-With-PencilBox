﻿using SMECommerce.Models.EntityModels;
using SMECommerce.Repositories;
using SMECommerce.Repositories.Abstractions;
using SMECommerce.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        ICategoryRepository _categoryRepository;
       

        public CategoryService( ICategoryRepository categoryRepository) : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
           
        }
       public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public ICollection<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category CategoryName(int id)
        {
            return _categoryRepository.CategoryName(id);
        }
    
      
    }
}
