using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFour
{
    public class Address
    {
        private string streetAddress;
        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        public string AdditionalAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Address(string streetAddress, string city, string state, string zip)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }
    }
}
