using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services.Abstractions
{
   public interface IProductService : IService<Item>
   {
        Item GetById(int id);
        ICollection<Item> GetAll(); 
        bool Save();
       
    }
}
