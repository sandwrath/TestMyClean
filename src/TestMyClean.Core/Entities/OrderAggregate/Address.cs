﻿using System;
using System.Collections.Generic;
using System.Text;
using TestMyClean.SharedKernel;

namespace TestMyClean.Core.Entities.OrderAggregate
{
    public class Address : BaseEntity
    {
        public string Street { get; private set; }

        public string City { get; private set; }

        public string State { get; private set; }

        public string Country { get; private set; }

        public string ZipCode { get; private set; }

        private Address() { }

        public Address(string street, string city, string state, string country, string zipcode)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipcode;
        }
    }
}
