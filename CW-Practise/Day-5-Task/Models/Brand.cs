﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Task.Models
{
   public class Brand
    {
        public int id { get; set; }
        public string Name { get; set; }      
        public ContactPerson ContactPerson { get; set; }
        public List<Item> Items { get; set; }
    }
}
