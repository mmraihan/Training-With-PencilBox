using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SMECommerce.Databases.DbContexts;
using SMECommerce.Repositories;
using SMECommerce.Repositories.Abstractions;
using SMECommerce.Services;
using SMECommerce.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.App.Configurations
{
    public class AppConfiguration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SMECommerceDbContext>(c => c.UseSqlServer("Server=DESKTOP-4BMDG8B;Database=SMEDb;Trusted_Connection=True;MultipleActiveResultSets=True"));
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductService, ProductService>();
        }
    }
}
