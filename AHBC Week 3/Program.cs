using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AHBC_Week_3
{
    class Program
    {
        static void Main(string[] args)
        {

            WorkingWithDictionaries();

            // LessonWork();

            Environment.Exit(0);

            string[] weapons = new string[] { "sword", "dagger", "bow", "wand" };
            string[] playerInventory = new string[10];
            playerInventory[0] = "health potion"; // First element
            playerInventory[9] = "rune of revival"; // Last element

            // ArrayList came between Arrays and Lists (not used often)
            ArrayList myStuff = new ArrayList();

            // Can accept any type
            myStuff.Add("breakfast");
            myStuff.Add(7);
            myStuff.Add(true);

            int CharacterAge = 12 + (int) myStuff[1];
            bool isValid = (bool)myStuff[2];

            // Lists
            List<string> weaponsList = new List<string>() { "sword", "dagger", "bow", "wand" };
            List<string> potions = new List<string>() { "healing potion", "water breathing potion" };
            List<string> enhancedInventory = new List<string>();
            List<int> damageIndicators = new List<int> { 20, 25, 28, 45 };

            // Add value to element
            playerInventory[0] = "health potion"; // First Element
            // Add value to List
            enhancedInventory.Add("magic potion"); // First Elemnent
            enhancedInventory.AddRange(weaponsList); // Add List to a list (As long as their of the same type)
            enhancedInventory.AddRange(potions); // Add second list to a list
            enhancedInventory.AddRange(weapons); // Add Array to a list

            // Add int to a string list
            enhancedInventory.Add(CharacterAge.ToString());

            // Add list of integers to a list of strings
            for (int i = 0; i < damageIndicators.Count; i++)
            {
                enhancedInventory.Add(damageIndicators[i].ToString());
            }
            // enhancedInventory.AddRange(damageIndicators); // Will not work

            // Adding strings to a list of integers
            List<int> enemyCount = new List<int>();

            //bool doAddMore = true;
            //while (doAddMore) // same as (doAddMore == true)
            //{
            //    Console.Write("How many enemies: ");
            //    enemyCount.Add(int.Parse(Console.ReadLine()));
            //    Console.Write("more? ");
            //    if (Console.ReadLine().ToLower().Trim() == "no")
            //    {
            //        doAddMore = false;
            //    }
            //}

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                enhancedInventory.Add(random.Next(1, 9).ToString());
            }

            List<string> meals = new List<string>();
            bool doContinue = true;

            while (doContinue == true)
            {
                Console.WriteLine("Add a meal: ");
                meals.Add(Console.ReadLine());
                Console.WriteLine("another");
                if (Console.ReadLine().ToLower().Trim() == "no")
                {
                    doContinue = false;
                }

                // Creates a size limit to the list
                if (meals.Count > 300)
                {
                    Console.WriteLine("No more allowed.");
                    doContinue = false;
                }
            }

            List<int> randomNumbers = new List<int>();
            doContinue = true;
            random = new Random();
            while (doContinue)
            {
                randomNumbers.Add(random.Next(0, 2000));
                if (randomNumbers.Count == 100)
                {
                    break;
                }
            }

            // Better way to add 100 random numbers
            for (int i = 0; i < 100; i++)
            {
                randomNumbers.Add(random.Next(0, 2000));
            }
            enhancedInventory.Add("dagger");
            
            

            try
            {
                Console.WriteLine(enhancedInventory[0]); // Throws error when no elements exist
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(weaponsList[0]);
                
            }

            // LessonWork();
            // InviteLunchBuddies();
            // GetAverageScore();
            // PracticeInterviewQuestions();
            // RandomDiscussion();

            enhancedInventory.Insert(10, "wood club");

            
            damageIndicators.Remove(12);
            enhancedInventory.RemoveAt(10); // will not remove the "wood club" because we already removed "dagger", shifting elements left
            int midpoint = (int)(enhancedInventory.Count) / 2 - 1;
            enhancedInventory.RemoveRange(midpoint, enhancedInventory.Count - midpoint); // Don't hardcode numbers here

            bool hasDagger = enhancedInventory.Contains("dagger");

            if (hasDagger)
            {
                int daggerLocation = enhancedInventory.IndexOf("dagger");

                int lastDaggerLocation = enhancedInventory.LastIndexOf("dagger");

                if (daggerLocation != lastDaggerLocation)
                {
                    Console.WriteLine("You have more than one dagger.");
                }

                Console.WriteLine($"The dagger is the {daggerLocation + 1} item in your inventory.");
            }

            // Removing all daggers
            while (hasDagger)
            {
                enhancedInventory.Remove("dagger"); // Most common one
                hasDagger = enhancedInventory.Contains("dagger");
            }

            foreach (string inventoryItem in enhancedInventory)
            {
                Console.WriteLine($"You have a {inventoryItem} in your inventory.");
                // enhancedInventory.Add("new thing"); // Can't add when using foreach
            }

            enhancedInventory.Clear(); // Clears the inventory

            Console.ReadKey();
        }

        public static bool IsEvenNumber(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void WorkingWithDictionaries()
        {
            List<string> tempList = new List<string>();
            tempList.Add("this");
            tempList.Add("that");

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("sad", "not happy, gloomy feelings");
            dictionary.Add("cat", "an annoying animal that should never be in my house.");
            dictionary.Add("cats", "many annoying animals that should never be in the house.");
            // dictionary.Add("cat", "a fun animal"); // Can't have duplicate keys (In this case, the duplicate key is "cat")
            dictionary.Add("dog", "a fun animal");
            dictionary.Add("ferret", "a fun animal");

            dictionary.Remove("cats");

            Dictionary<int, string> shoppingCart = new Dictionary<int, string>();
            shoppingCart.Add(12342, "Fancy Blue Shoes");
            shoppingCart.Add(12534, "Ripped Jeans");

            shoppingCart.Remove(12534);

            string itemToRemove = Console.ReadLine();
            itemToRemove = "Ripped Jeans";

            // Does the item exist
            bool doesItemExist = shoppingCart.ContainsValue(itemToRemove);
            int itemsKey = -1;
            // Get the key for the provided value
            foreach (var item in shoppingCart)
            {
                if (item.Value == itemToRemove)
                {
                    itemsKey = item.Key;
                    break; // So it won't loop through the rest if you've already found it
                }
            }

            shoppingCart.Remove(itemsKey);
            shoppingCart.Clear(); // Gets rid of all items

            Dictionary<string, List<string>> learnerFavoriteTopics = new Dictionary<string, List<string>>();

            List<string> stevesList = new List<string>() { "gaming", "camping", "biking" };
            List<string> aprilsList = new List<string>() { "reading", "hiking", "running", "writing" };
            List<string> kalindisList = new List<string>() { "emotions", "reptiles" };

            learnerFavoriteTopics.Add("steve", stevesList);
            learnerFavoriteTopics.Add("april", aprilsList);
            learnerFavoriteTopics.Add("kalindi", kalindisList);

            foreach (var learnerList in learnerFavoriteTopics)
            {
                Console.WriteLine($"The list of topics to talk to {learnerList.Key} about: ");
                foreach (string topic in learnerList.Value)
                {
                    Console.WriteLine(topic);
                }
            }

            Console.ReadKey();


            Dictionary<int, bool> drinkingAgeVerification = new Dictionary<int, bool>();
            drinkingAgeVerification.Add(18, false);
            drinkingAgeVerification.Add(21, true);
            drinkingAgeVerification.Add(5, false);
            drinkingAgeVerification.Add(7 - 2, IsEvenNumber(2));

            bool wasAddSuccessfull = drinkingAgeVerification.TryAdd(18, true); // If true, add to the dictionary
            if (wasAddSuccessfull == false)
            {
                Console.WriteLine("Did not add.");
            }

            // More than likely will see it this way
            int userInt = 25;
            bool userBool = true;
            bool doesTextExist = dictionary.ContainsValue("a fun animal");

            bool doesExist = drinkingAgeVerification.ContainsKey(userInt);
            if (doesExist)
            {
                Console.WriteLine("That already exists.");
            }
            else
            {
                drinkingAgeVerification.Add(userInt, userBool);
            }

            // KeyValuePair<int, bool> newEntry = new KeyValuePair<int, bool>(19, true);

            Dictionary<string, string> meals = new Dictionary<string, string>();
            meals.Add("breakfast", "");
            meals.Add("lunch", "");
            meals.Add("dinner", "");

            var mealKeys = meals.Keys;

            foreach (var key in mealKeys)
            {
                Console.WriteLine($"What did you have for {key}?");
                string userInput = Console.ReadLine();
                meals[key] = userInput;
            }

            // This code cannot be done. Use the code above
            //foreach (var meal in meals)
            //{
            //    Console.WriteLine($"What did you have for {meal.Key}?");
            //    string userInput = Console.ReadLine();
            //    meal.Value = userInput;
            //}

            Console.ReadKey();
        }

        public static void UserReference()
        {
            string userName = "Steve";
            string updatedName;
            CreateNewUserName(userName, out updatedName);
            Console.WriteLine(userName);
            ChangeUserName(ref userName);
            Console.WriteLine(userName);
        }

        public static void ChangeUserName(ref string name)
        {
            name = "Tim";
        }

        public static void CreateNewUserName(string name, out string newName)
        {
            newName = name + " Awesome";
        }

        public static void RandomDiscussion()
        {
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

        // This techincally does two things.
        // Change to a double, return a double.
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
            List<string> groceryList = new List<string> { "bread", "milk", "butter", "soda", "cheese" };

            groceryList.Add("ice cream");
            groceryList.Insert(0, "pop tarts");

            bool addMore = true;
            while (addMore)
            {
                Console.Write("add to your list: ");
                groceryList.Add(Console.ReadLine());
                Console.WriteLine("add another?");
                if (Console.ReadLine().ToLower().Trim() == "no")
                {
                    addMore = false;
                }
            }

            Console.Clear();
            Console.WriteLine("Your grocery list");
            foreach (string groceryItem in groceryList)
            {
                Console.WriteLine(groceryItem);
            }

            Console.ReadKey();
            

            // This will give the default values because the arrays are empty
            // Console.WriteLine($"name is {names[0]}, grade is {grades[0]}, answers are {answers[0]}");
        }

        static void WorkingWithStacksAndQueues()
        {
            Stack<string> deckOfCards = new Stack<string>(); // LIFO - Last in First Out
            deckOfCards.Push("ace of spades");
            deckOfCards.Push("two of hearts");

            Console.WriteLine(deckOfCards.Peek()); // Display the two of hearts without removing it.
            Console.WriteLine(deckOfCards.Pop()); // This will show the two of hearts and pop it off.
            Console.WriteLine(deckOfCards.Pop()); // This will show the ace of spades and pop it off

            Queue<string> onHoldCalls = new Queue<string>(); // FIFO - First in First Out
            onHoldCalls.Enqueue("Steve's grandma");
            onHoldCalls.Enqueue("Steve");
            onHoldCalls.Enqueue("Brian");

            Console.WriteLine(onHoldCalls.Dequeue()); // Steve's grandma <-- takes this off
            Console.WriteLine(onHoldCalls.Peek()); // Looks at "Steve" without removing it
            Console.WriteLine(onHoldCalls.Dequeue()); // Steve
            Console.WriteLine(onHoldCalls.Dequeue()); // Brian


        }
    }
}
