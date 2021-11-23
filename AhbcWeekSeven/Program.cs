using System;
using System.Collections.Generic;
using System.IO;

namespace AhbcWeekSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> savedList = FileHelper.BuildPokemonList(@"C:\Users\schan\Documents\Web Development\Education\Grand Circus\Full Stack C# .NET Bootcamp\Notes Code\AHBC Training Sessions\AhbcWeekSeven\pokemonList.txt");
            string namePath = @"C:\Users\schan\Documents\Web Development\Education\Grand Circus\Full Stack C# .NET Bootcamp\Notes Code\AHBC Training Sessions\AhbcWeekSeven\pokemonList.txt";
            //FileHelper.WriteToFile(namePath, "My name is Steve");
            //FileHelper.AppendToFile(namePath, "This is more stuff.");
            //FileHelper.AppendToFile(namePath, "Even more stuff.");
            //FileHelper.AppendToFile(namePath, "And even more stuff.");

            Pokemon pokemon = new Pokemon()
            {
                Name = "Ralts",
                Type = "Psychic",
                Attack = "Confusion"
            };

            FileHelper.AddPokemonToFile(namePath, pokemon);

            Console.WriteLine("Read Line"); ;
            Console.WriteLine(FileHelper.ReadFirstLine(namePath));

            Console.WriteLine("Read File"); ;
            Console.WriteLine(FileHelper.ReadEntireFile(namePath));

            Console.ReadKey();
        }
    }
}
