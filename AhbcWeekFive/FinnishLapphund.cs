using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    // Every FinnishLapphund "is a" Dog
    public class FinnishLapphund : Dog
    {
        public int AwesomenessLevel { get; set; }

        public override string GoPotty()
        {
            return "made big mess";
        }
    }

    
}
