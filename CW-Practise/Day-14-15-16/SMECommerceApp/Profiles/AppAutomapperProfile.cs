using AutoMapper;
using SMECommerce.Models.EntityModels;
using SMECommerceApp.Models.CategoryModel;
using SMECommerceApp.Models.IdentityModel;
using SMECommerceApp.Models.IdentityModels;
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
            CreateMap<Category, CategoryResultVM>();
            CreateMap<SignUpUserModel, SignUpUserModelVM>();
            CreateMap<SignUpUserModelVM, SignUpUserModel>();
            CreateMap<SignInUserModel, SignInUserModelVM>();
            CreateMap<SignInUserModelVM, SignInUserModel>();


         }
    }
}
