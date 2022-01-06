using Microsoft.EntityFrameworkCore;
using SMECommerce.Databases.DbContexts;
using SMECommerce.Models.EntityModels;
using SMECommerce.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerce.Repositories
{
    public class ProductRepository : Repository<Item>, IProductRepository
    {
        SMECommerceDbContext db;
        public ProductRepository(SMECommerceDbContext db) : base(db)
        {
           this.db = db;
        }

        public override Item GetById(int id)
        {
            var item = db.Products.FirstOrDefault(c => c.Id == id);
            return item;
        } 

    }
}
