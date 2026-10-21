using System;
using System.Collections.Generic;
using System.Text;

namespace DomainClasses.ECommerceShop.Data_Class
{
    public class Address
    {
        private readonly string street;
        private readonly string city;
        private readonly string state;
        private readonly string zipcode;

        public Address(string street, string city, string state, string zipcode)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
        }

        public override string ToString()
        {
            return $"{street}, {city}, {state} {zipcode}";
        }
    }
}
