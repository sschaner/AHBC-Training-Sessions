using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    /* Animal is the base class
     * abstract here means you have to inherit this class
     * Can't have a private abstract class.
     */
    public abstract class Animal
    {
        public string EyeColor { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string FoodType { get; set; }

        // Any method that is virtual can be overwritten
        public virtual void Grow(int growthAmount)
        {
            Height = Height + growthAmount;
        }

        public void AgeAnimal(int numberOfYears)
        {
            // Age = Age + numberOfYears; // same as below.
            Age += numberOfYears;
        }

        public virtual void Move(string newLocation)
        {
            newLocation = Location;
        }

        /* abstract classes can be inherited by other classes but not used to create an object
         * abstract will have no logic in it.
         * If you inherit, you must have logic
         * Must be an abstract class to use an abstract method.
         */
        public abstract string Speak();

        public abstract string GoPotty();

        // Examples of overloading the Sleep method.

        public string Sleep(int hours)
        {
            return $"Your animal slept for {hours} hours.";
        }

        /// <summary>
        /// The method to allow the animal to sleep
        /// </summary>
        /// <param name="hours">The number of hours the animal slep</param>
        /// <param name="location">The location of the animal sleeping</param>
        /// <returns></returns>
        public string Sleep(int hours, string location)
        {
            return $"Your animal slept for {hours} hours at {location}.";
        }

        public string Sleep(int hours, int minutes)
        {
            return $"Your animal slept for {hours} hours and {minutes} minutes.";
        }
        public string Sleep(string location, int partners)
        {
            return $"Your animal slept at {location} with {partners} friends.";
        }
        public string Sleep(string location)
        {
            return $"Your animal slept at {location}.";
        }
    }
}
