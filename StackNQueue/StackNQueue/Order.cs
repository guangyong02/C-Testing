using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackNQueue
{
    internal class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }  
        public Order(int orderId, int orderQuantity)
        {
            OrderId = orderId;
            OrderQuantity = orderQuantity;
        }
    }
}
