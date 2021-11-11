using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    public class Mammal : Animal
    {
        public string FurType { get; set; }

        public override string GoPotty()
        {
            return "go outside";
        }

        public override string Speak()
        {
            return "growl";
        }


    }
}
