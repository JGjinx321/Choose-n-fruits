using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Choose_n__fruits.Models
{
    class Order
    {
        public Guid? OrderId { get; set; }

        public string ProductName{ get; set; }

        public DateTime ShippedDate { get; set; }

        public double Total { get; set; }

        public int OrderDetailsId { get; set; }

        public Order(Order order)
        {
            order.OrderId = OrderId;

            order.ShippedDate = ShippedDate;

            order.Total = Total;
        }

    }
}
