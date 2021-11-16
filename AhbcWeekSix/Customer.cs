using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekSix
{
    public class Customer : Person
    {
        public bool PassedCreditCheck { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public void UpdateCreditCheckFlag(bool value)
        {
            PassedCreditCheck = value;
        }
    }
}
