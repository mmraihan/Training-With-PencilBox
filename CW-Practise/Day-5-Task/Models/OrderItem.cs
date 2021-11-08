using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Task.Models
{
   public class OrderItem
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public float Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
        public Order Order { get; set; }


    }
}
