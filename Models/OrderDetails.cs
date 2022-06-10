using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Choose_n__fruits.Models
{
    class OrderDetails
    {
        public Guid? OrderDetailsId{ get; set; }

        public int PaymentId { get; set; }

        public DateTime OrderDate { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public int CustomerId { get; set; }

        public DateTime EstDeliverYDate { get; set; }

        public OrderDetails(List<Order> orders)
        {
            foreach(Order o in orders)
            {
                Console.WriteLine(o.ProductName);
            }
        }
    }
}
