using AutoMapper;
using SMECommerce.Models.EntityModels;
using SMECommerceApp.Models.CategoryModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.App.Configurations
{  
    public class AppAutomapperProfile : Profile
    {
        public AppAutomapperProfile()
        {
            CreateMap<CategoryCreate, Category>();
            CreateMap<CategoryEditVM, Category>();
            CreateMap<Category, CategoryCreate>();
            CreateMap<Category,CategoryEditVM>();           
         }
    }
}
