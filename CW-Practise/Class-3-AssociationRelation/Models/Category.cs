using System.Collections.Generic;

namespace Class_3_AssociationRelation.Models
{
    public class Category
    {

        public Category()
        {
            Products = new List<Product>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; private set; }
    }
}
