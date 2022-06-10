using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Choose_n__fruits.Models
{
    class Customer
    {
        public Guid? CustomerId { get; set; }

        public string BillingAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Street{ get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int OrderId { get; set; }

        public Customer(Customer customer)
        {
            customer.FirstName = FirstName;

            customer.LastName = LastName;

            customer.BillingAddress = BillingAddress;

            customer.PhoneNumber = PhoneNumber;

            customer.Email = Email;

            customer.Street = Street;

            customer.City = City;

            customer.State = State;

            customer.ZipCode = ZipCode;
        }
    }
}
