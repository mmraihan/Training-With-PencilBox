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
    public class ProductRepository : IProductRepository
    {
        SMECommerceDbContext db;
        public ProductRepository(SMECommerceDbContext db)
        {
           this.db = db;
        }

        public bool Add(Item item)
        {
            db.Products.Add(item);
            return Save();
           
        }

        public bool Update(Item item)
        {
            db.Products.Update(item);
            return Save();
        }

        public bool Remove(Item item)
        {
            db.Products.Remove(item);
            return Save();
        }

        public Item GetById(int id)
        {
            var item = db.Products.FirstOrDefault(c => c.Id == id);
            return item;
        } 

        public ICollection<Item> GetAll()
        {
            var items = db.Products.Include(c => c.Category).ToList();
            return items;
        }

      


        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

        


    }
}
