using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    // Every Dog "is a" Animal
    public class Dog : Mammal, ILiveBirthGiver
    {
        // Nobody who inherits from me can override speak (sealed) <-- Every Dog will say "woof"
        public sealed override string Speak()
        {
            return "woof";
        }

        // Being virtual, each dog breed can override this.
        public override string GoPotty()
        {
            return "made mess";
        }

        public sealed override void Move(string newLocation)
        {
            GoPotty();
            Location = newLocation;
        }

        public void GiveLiveBirth()
        {
            throw new NotImplementedException();
        }

        //public override void Sleep(int hours)
        //{
        //    int sleepTime = hours;
        //}
    }
}
