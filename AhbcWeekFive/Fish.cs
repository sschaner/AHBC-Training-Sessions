using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    // EVery Fish "is a" Animal
    class Fish : Animal, IEggLayer
    {
        public int Length { get; set; }
        public string WaterType { get; set; }
        public int IncubationTime { get; set; }

        public override string GoPotty()
        {
            return "nobody noticed";
        }

        // This method is overriding a virtual method from the Animal class.
        public override void Grow(int growthAmount)
        {
            Length = Length + growthAmount;
        }

        public bool LayEggs()
        {
            throw new NotImplementedException();
        }

        public override string Speak()
        {
            return "glub";
        }
    }
}
