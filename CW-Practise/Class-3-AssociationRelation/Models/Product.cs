using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3_AssociationRelation.Models
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public int CategoryCode { get; set; }
        public DateTime ManufacturingDate { get; set; }
    }
}
