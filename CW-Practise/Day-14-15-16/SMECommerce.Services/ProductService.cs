﻿using SMECommerce.Models.EntityModels;
using SMECommerce.Repositories.Abstractions;
using SMECommerce.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services
{
    public class ProductService : Service<Item>,  IProductService
    {
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
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
