using SMECommerce.Models.EntityModels;
using SMECommerce.Repositories.Abstractions;
using SMECommerce.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public bool Add(Item item)
        {
            return _productRepository.Add(item);
        }

        public bool Update(Item item)
        {
            return _productRepository.Update(item);
        }

        public bool Remove(Item item)
        {

            return _productRepository.Remove(item);
        }

        public Item GetById(int id)
        {

            return _productRepository.GetById(id);
        }
        public ICollection<Item> GetAll()
        {
            return _productRepository.GetAll();
        }

        public bool Save()
        {
           return _productRepository.Save();
        }

    }
}
