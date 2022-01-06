using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Repositories.Abstractions
{
   public interface IProductRepository
    {
        bool Add(Item item);
        bool Update(Item item);
        public bool Remove(Item item);
        public Item GetById(int id);
        public ICollection<Item> GetAll();
        public bool Save();
       

    }
}
