using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    public class Turtle : Reptile, IEggLayer
    {
        public int IncubationTime { get; set; }

        public void LayEggs()
        {
            throw new NotImplementedException();
        }
    }
}
