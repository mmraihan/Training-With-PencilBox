using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Task.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public Customer Customer { get; set; }
        public decimal TotalItems { get; set; }
        public double TotalPrice { get; set; }
        public List<OrderItem> OrderItems { get; set; }



    }
}
