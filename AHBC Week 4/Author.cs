using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFour
{
    public class Author
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        
        private string website;
        public string Website
        {
            get { return website; }
            set { website = value; }
        }

        private Address authorsAddress;
        public Address AuthorsAddress
        {
            get { return authorsAddress; }
            set { authorsAddress = value; }
        }

        // Two different ways for creating a constructor is called overloading

        public Author(string fullName, string email)
        {
            FullName = fullName;
            EmailAddress = email;
        }

        public Author(string fullName, string email, string website, Address address)
        {
            FullName = fullName;
            EmailAddress = email;
            Website = website;
            AuthorsAddress = address;
        }

        public Author(string fullName)
        {
            FullName = fullName;
        }
    }
}
