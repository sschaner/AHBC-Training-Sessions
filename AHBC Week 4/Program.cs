using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AhbcWeekFour
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithRegEx();
            Console.ReadKey();
            WorkWithEnums();
            WorkWithLINQ();
            WorkWithLambda();
        }

        public static void WorkWithRegEx()
        {
            // www.regex101.com
            // Regular Expressions (RegEx)
            string pattern = "^[a-zA-Z]+$";
            pattern = @"[a-zA-Z\d]+$"; // \d is 0-9

            string namePattern = @"^[A-Z][a-zA-Z]+ [A-Z][a-zA-Z]+[a-zA-Z ]*"; // First and last name
            string streetAddressPattern = @"^[0-9]+ [A-Z][a-zA-Z ]+$";
            string zipCode = @"^[0-9]{5}"; // numbers, exactly 5 times
            string socialSecurityNumber = "^[0-9]{3}-[0-9]{2}-[0-9]{4}$";
            string canadianPostalCode = "^[A-Z][0-9][A-Z] [0-9][A-Z][0-9]$";
            string websiteURL = "^[w|W]{3}.[A-Za-z0-9_]+.[A-Za-z]{2,4}$";
            websiteURL = @"^(http|https|ftp):[\/]{2}([a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,4})(:[0-9]+)?\/?([a-zA-Z0-9\-\._\?\,\'\/\\\+&amp;%\$#\=~]*);
";

            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();

            bool isMatch = regex.IsMatch(input);

            if (isMatch == false)
            {
                Console.WriteLine("Bad input");
            }

            Console.ReadKey();


        }

        public static void WorkWithEnums()
        {
            Dictionary<string, BookGenre> bookCollection = new Dictionary<string, BookGenre>();

            bookCollection.Add("Dune", BookGenre.Mystery);
            bookCollection.Add("Green Lights", BookGenre.NonFiction);
            bookCollection.Add("Find Your Why", BookGenre.PersonalDevelopment);

            Console.WriteLine("Add a book");
            Console.WriteLine("Book title?");
            string bookTitle = Console.ReadLine();
            Console.WriteLine("Book genre");
            Console.WriteLine("1 = sci fi, 2 = romance, 3 = western, 4 = personalDevelopment, 5 = nonFiction, 6 = mystery");
            // Gets the string, parses it to an int, casts the int to a BookGenre, and stores it into userBookGenre
            BookGenre userBookGenre = (BookGenre) int.Parse(Console.ReadLine());

            bookCollection.Add(bookTitle, userBookGenre);

            switch (userBookGenre)
            {
                case BookGenre.SciFi:

                    break;
                case BookGenre.Romance:

                    break;
                case BookGenre.Western:

                    break;
                case BookGenre.PersonalDevelopment:

                    break;
                case BookGenre.NonFiction:

                    break;
                case BookGenre.Mystery:

                    break;
                default:

                    break;
            }

            Dictionary<string, BookStatus> libraryCollection = new Dictionary<string, BookStatus>();

            libraryCollection.Add("Dune", BookStatus.CheckedOut);
            libraryCollection.Add("Green Lights", BookStatus.onShelf);
            libraryCollection.Add("Find Your Why", BookStatus.onShelf);

            Console.WriteLine("There are the available books.");
            foreach (var item in libraryCollection.Where(x => x.Value == BookStatus.onShelf))
            {
                Console.WriteLine(item.Key);
            }

            if (libraryCollection[bookTitle] == BookStatus.CheckedOut)
            {
                Console.WriteLine($"Sorry. {bookTitle} is checked out.");
            }

        }

        public static void WorkWithLINQ()
        {
            List<string> movies = new List<string>() { "Dune", "Jurassic Park", "Planet of the Apes", "Venom", "Friday the 13th" };

            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }

            movies.Reverse(); // This is a permanent reverse (actually changing it). Have to reverse it back.

            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine($"The first movie in the list is {movies.First()}");

            Console.Clear();


            List<int> payChecks = new List<int>() { 100, 233, 32, 236, 6543 };

            Console.WriteLine($"Your biggeest paycheck is {payChecks.Max()}");
            Console.WriteLine($"Your smallest paycheck is {payChecks.Min()}");

            // payChecks.Clear();

            if (payChecks.FirstOrDefault() > 100)
            {
                Console.WriteLine("Yeah!");
            }
            else
            {
                Console.WriteLine("Boo");
            }
            

            // Reverses a string
            string longString = "asdfghjkl";
            char[] stringChar = longString.ToCharArray();
            stringChar.Reverse();
        }

        public static bool GetVotingLegality(int age)
        {
            if (age > 17)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void WorkWithLambda()
        {
            // x => x.[something]

            List<string> movies = new List<string>() { "Dune", "Jurassic Park", "Planet of the Apes", "Venom", "Friday the 13th", "Peter Pan" };

            List<int> payChecks = new List<int>() { 100, 233, 32, 236, 6543 };

            foreach (var item in payChecks.Where(x => x > 100))
            {
                Console.WriteLine($"{item}");
            }

            // Get movies that start with "P"
            // movies.Where(x => x.StartsWith("P"));

            foreach (var item in movies.Where(x => x.StartsWith("P")))
            {
                Console.WriteLine(item);
            }

            // Get paychecks greater than 100. 'paycheck' is the label we use to represent each element in the list
            //payChecks.Where(paycheck => paycheck > 100); // Like an arrow function in JavaScript

            movies.Sort();

            foreach (var item in movies)
            {
                Console.WriteLine(item);
            }

            movies.Reverse(); // Sorts in descending order

            foreach (var item in movies)
            {
                Console.WriteLine(item);
            }


            

        }
    }
}
