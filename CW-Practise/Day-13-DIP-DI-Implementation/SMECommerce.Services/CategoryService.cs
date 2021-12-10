using SMECommerce.Models.EntityModels;
using SMECommerce.Repositories;
using SMECommerce.Repositories.Abstractions;
using SMECommerce.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services
{
   public class CategoryService : ICategoryService
    {
        ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public Category GetById(int id)
        {
            //------------Logic----------------------
            //------------Logic----------------------
            //------------Logic----------------------
            //------------Logic----------------------
            return _categoryRepository.GetById(id);
        }

        public ICollection<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public bool Add(Category category)
        {
            return _categoryRepository.Add(category);
        }

        public bool Update(Category category)
        {
            return _categoryRepository.Update(category);
        }

        public bool Remove(Category category)
        {
            return _categoryRepository.Remove(category);
        }

        public Category CategoryName(int id)
        {
            return _categoryRepository.CategoryName(id);

        }
    }
}
