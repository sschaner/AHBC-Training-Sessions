using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekSix
{
    public abstract class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
