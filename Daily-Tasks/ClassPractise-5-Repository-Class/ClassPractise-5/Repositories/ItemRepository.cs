using ClassPractise_5.Data;
using ClassPractise_5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractise_5.Repositories
{
   public class ItemRepository
    {
        SMEDbContext db;
        public ItemRepository()
        {
            db = new SMEDbContext();
        }

        public bool Add(Item item)
        {
            db.Items.Add(item);
            int successCount = db.SaveChanges();
            return successCount > 0;
        }


        public bool Update(Item item)
        {
            db.Items.Update(item);
            int successCount = db.SaveChanges();
            return successCount > 0;

        }



        public bool Remove(Item item)
        {
            db.Items.Remove(item);
            int successCount = db.SaveChanges();
            return successCount > 0;
        }

        public Item GetById(int id)
        {
            return db.Items.FirstOrDefault(c => c.Item_Id == id);
        }

        public ICollection<Item> GetAll()
        {
            return db.Items.Include(c => c.Brand).ToList();
        }
    }
}
