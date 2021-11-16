using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekSix
{
    public class Vehicle
    {
        double currentAcceleration;
        public double CurrentAcceleration {get; set;}

        // Open for extension
        public virtual void Accelerate(double accelerationRate)
        {
            currentAcceleration += accelerationRate;
        }

        public void Break(double decelerationRate)
        {
            currentAcceleration -= decelerationRate;
        }
    }
}
