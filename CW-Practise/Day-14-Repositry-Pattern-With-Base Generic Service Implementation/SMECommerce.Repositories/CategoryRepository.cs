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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        SMECommerceDbContext db;
        public CategoryRepository(SMECommerceDbContext db) : base(db)
        {
            this.db = db;
        }
        public override Category GetById(int id)
        {
            return db.Categories.FirstOrDefault(c => c.Id == id);
        }

        public override ICollection<Category> GetAll()
        {
            return db.Categories.Include(c => c.Items).ToList();
        }
 
        public Category CategoryName(int id)
        {
            return db.Categories.FirstOrDefault(c => c.Id == id);

        }

        public bool isValid()
        {
            throw new NotImplementedException();
        }

      
    }
}
