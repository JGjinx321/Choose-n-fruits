using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Choose_n__fruits.Models
{
    class Payment
    {
        public Guid? PaymentId { get; set; }

        public string PaymentType { get; set; }

        static Payment()
        {
            Payment Visa = new Payment();

            Payment MasterCard = new Payment();

        }
    }
}
