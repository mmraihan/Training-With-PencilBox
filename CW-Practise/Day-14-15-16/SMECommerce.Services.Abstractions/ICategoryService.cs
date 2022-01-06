using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services.Abstractions
{
    public interface ICategoryService : IService<Category>
    {
        Category GetById(int id);
        ICollection<Category> GetAll();           
        Category CategoryName(int id);
       
    }
}
