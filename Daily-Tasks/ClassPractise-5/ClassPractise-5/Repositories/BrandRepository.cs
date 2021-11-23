﻿using ClassPractise_5.Data;
using ClassPractise_5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractise_5.Repositories
{
   public class BrandRepository
    {
       SMEDbContext db;
        public BrandRepository()
        {
            db = new SMEDbContext();
        }

        public bool Add(Brand brand)
        {
            db.Brands.Add(brand);
            return Save();
        }

        public bool Add(List<Brand> brands)
        {
            db.Brands.AddRange(brands);
            return Save();
        }


        public bool Update(Brand brand)
        {
            db.Brands.Update(brand);
            return Save();

        }

        public bool Remove(Brand brand)
        {
            db.Brands.Remove(brand);
            return Save();
        }

        public Brand GetById(int id)
        {
            return db.Brands.FirstOrDefault(c => c.Brand_Id == id);
        }

        public ICollection<Brand> GetAll()
        {
            return db.Brands.Include(c =>c.Items).ToList();
        }

        public bool Save()
        {
           return db.SaveChanges ()>0;
        }



    }
}