using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewBagDemo.Models
{
    public class FormEmployee
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public int Married { get; set; }
    }

    public enum Gender
    {
        Male,Female
    }
}
