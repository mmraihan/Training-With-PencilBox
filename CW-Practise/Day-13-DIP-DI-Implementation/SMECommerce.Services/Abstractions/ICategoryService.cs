using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services.Abstractions
{
    public interface ICategoryService
    {
        Category GetById(int id);


        ICollection<Category> GetAll();
               

        bool Add(Category category);


        bool Update(Category category);

        bool Remove(Category category);


        Category CategoryName(int id);
       
    }
}
