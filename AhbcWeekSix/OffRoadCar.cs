using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekSix
{
    public class OffRoadCar : Car
    {
        public double CurrentAltitude { get; set; }
        public override void Accelerate(double multiplier)
        {
            CurrentAcceleration *= multiplier;
        }

        public void IncreaseAltitude (double multiplier)
        {
            CurrentAltitude *= multiplier;
        }
    }
}
