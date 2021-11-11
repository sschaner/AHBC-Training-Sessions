using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    public class Reptile : Animal
    {
        public string SkinType { get; set; }
        public override string GoPotty()
        {
            return "go in water bowl";
        }

        public override string Speak()
        {
            return "hiss";
        }
    }
}
