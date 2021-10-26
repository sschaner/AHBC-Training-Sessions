using System;
using System.Text;

namespace AHBC_Week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // LessonWork();
            // InviteLunchBuddies();
            // GetAverageScore();
            // PracticeInterviewQuestions();

            Random random = new Random();
            int userInput = 12;
            int dieOne = random.Next(1, userInput + 1);
            int dieTwo = random.Next(1, 7);

            Console.WriteLine($"Die one {dieOne}. Die two {dieTwo}.");

            // 10 random numbers
            //for (int i = 0; i < 10; i++)
            //{
            //    Random random = new Random();
            //    int number = random.Next(1, 11); // Random number between 1 and 10
            //    Console.WriteLine($"{i+1}: {number}");
            //}

            Console.ReadKey();
        }

        public static void PracticeInterviewQuestions()
        {
            string testString = "This is a test string";
            //testString = "racecaR";
            
            char[] stringLetters = testString.ToCharArray();
            string reversedString = "";
            StringBuilder builder = new StringBuilder();

            // Write code to display a string in reverse <-- Very common interview question for entry level developer
            for (int i = stringLetters.Length - 1; i >= 0; i--)
            {
                builder.Append(stringLetters[i]);
                //reverseString = reverseString + stringLetters[i];
            }
            reversedString = builder.ToString();
            Console.WriteLine(reversedString);

            // Write code to determine palidrome <-- also a common interview question
            bool isPalidrome = false;

            if (reversedString.ToLower().Trim() == testString.ToLower().Trim())
            {
                isPalidrome = true;
            }

            Console.WriteLine($"Is palidrome: {isPalidrome}");

            // Count the number of vowels in a string
            // Loop through characters
            int vowelCounter = 0;
            for (int i = 0; i < stringLetters.Length; i++)
            {
                switch (stringLetters[i].ToString().ToLower())
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        // Increment vowel counter
                        vowelCounter++;
                        break;
                }
            }

            string vowelsTerm = DetermineCorrectPluralUsage("vowel", vowelCounter);
            

            Console.WriteLine($"There are {vowelCounter} {vowelsTerm}.");

            Console.ReadKey();
        }

        // Bring in a term and the count
        // Return the term to use
        
        public static string DetermineCorrectPluralUsage(string term, int count)
        {
            // If count > 1 add an 's'
            if (count > 1)
            {
                return term + "s";
            }
            else
            {
                return term;
            }
            return term;
        }

        public static void GetAverageScore()
        {
            int[] scores = new int[] { 98, 87, 98, 67, 56, 74, 83 };

            // Add all numbers, then divide by how many scores
            int numberOfScores = scores.Length;

            int totalScore = -1;
            for (int i = 0; i < scores.Length; i++)
            {
                totalScore += scores[i];
                // totalScore = totalScore + scores[i];
            }

            double averageScore = totalScore / numberOfScores;
            Console.WriteLine($"Your average test score is {averageScore}.");
        }

        public static void InviteLunchBuddies()
        {
            string[] listOfFriends = GreetZachsFriends();
            string[] myFriends = new string[3] { "Gynell", "Hannah", "Chris" };

            string[] lunchBuddies = new string[8];

            listOfFriends.CopyTo(lunchBuddies, 0);
            myFriends.CopyTo(lunchBuddies, 5);

            /*
             // Same as the CopyTo
            int myFriendsCounter = 0;
            for (int i = 0; i < lunchBuddies.Length; i++)
            {
                if (i < 5)
                {
                    lunchBuddies[i] = listOfFriends[i];
                }

                else
                {
                    lunchBuddies[i] = myFriends[myFriendsCounter];
                    myFriendsCounter++;
                }
            }
            */

            for (int i = 0; i < lunchBuddies.Length; i++)
            {
                Console.WriteLine($"Hey {lunchBuddies[i]}, come have lunch with me.");
            }
        }



        public static string[] GreetZachsFriends()
        {
            string[] friendsList = new string[] { "Brian", "Steve", "Emily", "Kyle", "Scott" };

            for (int i = 0; i < friendsList.Length; i++)
            {
                Console.WriteLine($"Hi {friendsList[i]}!");
            }

            return friendsList;
        }

        public static void LessonWork()
        {
            string breakfast = "pancakes";

            // declaring the array meals
            string[] meals = new string[3];

            meals[0] = "pancakes";
            meals[1] = "sandwich";
            meals[2] = "meatloaf";
            // Visual code won't stop you from doing this. This is a runtime error (IndexOutOfRangeException)
            // meals[3] = "ice cream";

            int[] ages = new int[] { 12, 14, 13, 15, 20, 56 };

            ages[3] = 145;

            string[] names = new string[2];
            int[] grades = new int[4];
            bool[] answers = new bool[5];

            int answerCount = answers.Length; // give the number of elements in the array 

            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine($"The answer is {answers[i]}");
            }

            string[] mealNames = new string[3] { "breakfast", "lunch", "dinner" };

            // This is the same as above
            /*
            mealNames[0] = "breakfast";
            mealNames[1] = "lunch";
            mealNames[2] = "dinner";
            */

            // Both the arrays have to be the same length
            for (int i = 0; i < meals.Length; i++)
            {
                // Console.Write($"What was meal #{i + 1}: " );
                Console.Write($"What did you have for {mealNames[i]}? ");
                string userAnswer = Console.ReadLine();
                meals[i] = userAnswer;
            }

            Console.Clear();
            Console.WriteLine("Your meals...");
            for (int i = 0; i < meals.Length; i++)
            {
                Console.WriteLine(meals[i]);
            }

            // string[] healthyMeals = new string[5];
            string[] healthyMeals = new string[] { "bread", "milk", "butter", "soda", "cheese" };
            // What array do you want to copy into and what element do you want to start with
            meals.CopyTo(healthyMeals, 0); // This will override the first 3 elements.

            /*
            // This will replace the last 2 elements
            meals.CopyTo(healthyMeals, 3);

            healthyMeals[3] = "ice cream";
            healthyMeals[4] = "pop tarts";
            */

            // This will give the default values because the arrays are empty
            // Console.WriteLine($"name is {names[0]}, grade is {grades[0]}, answers are {answers[0]}");
        }
    }
}
