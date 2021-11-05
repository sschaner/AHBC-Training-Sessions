using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFour
{
    class Customer
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Customer (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string CustomerGreeting()
        {
            string output = $"Welcome {firstName} {lastName}.";
            return output;
        }
    }
}
