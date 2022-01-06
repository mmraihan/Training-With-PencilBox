using Microsoft.EntityFrameworkCore;
using SMECommerce.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMECommerce.Repositories
{
    public abstract class Repository<Y> : IRepository<Y> where Y : class //where Y : class is a Genecric Constraint
    {
        DbContext _db;
        public Repository(DbContext db)
        {
            _db = db;
        }

        private DbSet<Y> Table
        { 
            
            get 
                {
                    return _db.Set<Y>();
                }
        }


        public virtual bool Add(Y entity)
        {
            _db.Add(entity);
            return Save();
        }

        public virtual ICollection<Y> GetAll()
        {
            return Table.ToList();
        }

        public abstract Y GetById(int id); // Can not implemnt in base class
       

        public virtual bool Remove(Y entity)
        {
            _db.Remove(entity);
            return Save();
        }     

        public virtual bool Update(Y entity)
        {
            _db.Update(entity);
            return Save();
        }

        public bool Save()
        {
            return _db.SaveChanges()>0;
        }
    }
}
