using System;
using System.Collections.Generic;
using System.Linq;

namespace MockAssessmentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            StarWarsHelper swHelper = new StarWarsHelper();
            string[] people = new string[] { "Luke", "Yoda", "Han" };
            int index = swHelper.AddStarWarsCharacters(people);
            Console.WriteLine($"Yoda index = {index}");

            Dictionary<string, int> combatStats = new Dictionary<string, int>()
            {
                { "Luke", 400 },
                { "Yoda", 1000 },
                { "JarJar", 12345 }
            };
            string strongest = swHelper.DeathStarCombat(combatStats);
            Console.WriteLine($"The strongest warrior is {strongest}.");

            string[] planets = new string[] { "Pluto", "Neptune", "Jupiter", "Saturn" };
            List<string> reversedButNotAlphabeticalPlanets = swHelper.ConvertPlanets(planets);
            foreach (string planet in reversedButNotAlphabeticalPlanets)
            {
                Console.WriteLine(planet);
            }

            List<int> droidlist = new List<int>() { 2, 1, 3, 4, 5, 6, 6, 7, 8, 9, 10 };
            double averageDroid = swHelper.AverageDroids(droidlist);
            Console.WriteLine(averageDroid);

            Console.WriteLine(swHelper.TryToCatchDarthVader("2"));
            Console.WriteLine(swHelper.TryToCatchDarthVader("vader"));

            Console.ReadKey();
        }

        
    }
}
