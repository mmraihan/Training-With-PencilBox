using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Repositories.Abstractions
{
   public  interface ICategoryRepository
    {
        Category GetById(int id);


        ICollection<Category> GetAll();


        bool Add(Category category);


        bool Update(Category category);

        bool Remove(Category category);


        Category CategoryName(int id);

    }
}
