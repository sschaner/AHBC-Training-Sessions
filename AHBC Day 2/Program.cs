using System;
using System.Text;

namespace AHBC_Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What are you doing?");
            string answer = Console.ReadLine();
            string outputMessage = "";

            int funValue = GetWednesdayNightFun(answer, out outputMessage);

            Console.WriteLine($"Fun level: {funValue}, {outputMessage}");
            Console.ReadKey();

            // DoStringManipulation();

            SayHello();
            // Get the user's name
            string userName = GetUserName();
            // Tell user they have a nice name
            Console.WriteLine($"{userName} is a very nice name.");

            int userAge = GetUserAge();

            int computerAge = 50;
            int ageDifference = 50;

            try
            {
                ageDifference = CalculateUserAgeDifference(userAge, computerAge); // Must be in the same order as below
            }
            catch (ArgumentException ex)
            {
                // Handle retry logic

            }


            // Order doesn't matter if you do it this way. Not used often.
            ageDifference = CalculateUserAgeDifference(computerAgeValue: computerAge, userAgeValue: userAge);

            // Tell the user, by name, the age difference and ask if it makes sense.
            bool doesMakeSense = AskIfMakesSense(userName, ageDifference);

            // Get ticket price
            double price = GetTotalPrice(2, true);



            // Either way is fine
            int answerFromMethod = AddNumbers();
            int copyOfAnswer = -1;
            copyOfAnswer = AddNumbers();

            string friends = GetFriendList();

            Console.ReadKey();
        }

        public static bool ValidateNumber(string userInput, int minValue, int maxValue, out int validNumber)
        {
            try
            {
                int number = int.Parse(userInput);
                if (number >= minValue && number <= maxValue)
                {
                    validNumber = number;
                    return true;
                }
                else
                {
                    validNumber = -1;
                    return false;
                }
            }
            catch (FormatException ex)
            {
                validNumber = -1;
                return false;
            }
        }

        public static void TestLogic()
        {
            string friendList = "matt|mary";
            string userInput = "scott";
            AddFriendToList(userInput, ref friendList);
            Console.WriteLine(friendList);
        }

        public static string GetFriendList()
        {
            bool doContinue = true;
            string friendList = "";

            while (doContinue == true)
            {
                string userInput = "";
                Console.WriteLine("What is your friends name?");
                userInput = Console.ReadLine();
                AddFriendToList(userInput, ref friendList);


                Console.WriteLine("Add another friend: ");
                userInput = Console.ReadLine();
                if (userInput.ToLower().Trim() == "no")
                {
                    doContinue = false;
                }
            }

            return friendList;
        }

        public static void GetNumberOfKids()
        {
            Console.WriteLine("How many kids?");
            string userInput = Console.ReadLine();

            int numberOfKids = -1;

            // This is the one you'll use the most with the out parameter. Will always return a bool
            // If true, the result is put into numberOfKids
            bool isValidNumber = int.TryParse(userInput, out numberOfKids); // Use this for input

            if (isValidNumber == false)
            {
                // retry logic
            }
        }

        // ref means "reference" (this changes the value of the variable in the calling method) <-- Not used too often
        private static void AddFriendToList(string friend, ref string friendList)
        {
            friendList = friendList + "|" + friend;
        }

        // numberOfKids is optional and has a default value of 0
        public static double GetTotalPrice(int numberOfAdults, bool getsDiscount, int numberOfKids = 0)
        {
            double adultPrice = 5.50;
            double kidPrice = 1.75;

            double totalPrice = numberOfAdults * adultPrice + numberOfKids * kidPrice;

            if (getsDiscount == true)
            {
                totalPrice = GetDiscountedPrice(totalPrice);
            }

            return totalPrice;
        }

        private static double GetDiscountedPrice(double currentPrice) // private because it's being used by another class
        {
            const double DISCOUNTPERCENTAGE = .5;

            return currentPrice * DISCOUNTPERCENTAGE;
        }

        public static bool AskIfMakesSense(string userName, int ageDifference)
        {
            Console.WriteLine($"{userName} the age difference is {ageDifference}");
            Console.WriteLine("Does this make sense (yes/no)?");
            string userResponse = Console.ReadLine();

            if (userResponse.ToLower().Trim() == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int CalculateUserAgeDifference(int userAgeValue, int computerAgeValue) // Must be in the same order as above
        {
            if (userAgeValue <= 0 || computerAgeValue <= 0)
            {
                throw new ArgumentException("Ages must be greater than 0.");

            }

            int difference = computerAgeValue - userAgeValue;

            if (userAgeValue > computerAgeValue)
            {
                difference = userAgeValue - computerAgeValue;
            }
            else
            {
                difference = computerAgeValue - userAgeValue;
            }

            return difference;
        }

        public static string GetUserName()
        {
            Console.Write("What is your name: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static int GetWednesdayNightFun(string activity, out string message)
        {
            int funValue = -1;
            switch (activity.ToLower().Trim())
            {
                case "coding":
                    funValue = 10;
                    message = "You must be a coding whiz!";
                    break;
                case "streaming":
                case "reading":
                    funValue = 9;
                    message = "That is a close second.";
                    break;
                case "mowing the lawn":
                case "nascar":
                    funValue = 4;
                    message = "Look at that neatly cut lawn.";
                    break;
                default:
                    funValue = 1;
                    message = "That's no fun.";
                    break;
            }

            return funValue;
        }

        public static int GetUserAge()
        {
            Console.WriteLine("How old are you?");
            string userInput = Console.ReadLine();
            int userAge = -1;

            bool isValid = ValidateNumber(userInput, 5, 106, out userAge);

            CalculateUserAgeDifference(userAge, 50);
            
            return userAge;
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello.");
        }

        public static int AddNumbers()
        {
            int answer = 2 + 2;
            string test = "";
            // return answer; won't return
            return answer;
        }

        public static string GetQuote(string sentence)
        {
            int locationOfQuote = sentence.IndexOf("\"");
            int locationOfLastQuote = sentence.LastIndexOf("\"");
            string actualQuote = sentence.Substring(locationOfQuote + 1, locationOfLastQuote - locationOfQuote - 1);
            return actualQuote;
        }

        public static void DoStringManipulation() // method signature
        {
            // String Method

            // ToLower - ToUpper
            // TrimStart - TrimEnd - Trim

            try
            {
                // Logic goes here
                // Runs fine if no exception


                // Replace
                string message = "This course is okay.";
                string newMessage = message.Replace('i', 'o');
                newMessage = message.Replace("okay", "great");

                string templateMessage = "hello [name] how are you?";
                int hLocation = templateMessage.IndexOf('h'); // Searches for the index of 'h'. It is case sensitive. This will output 0
                int oLocation = templateMessage.IndexOf('o'); // 4

                int otherLocation = templateMessage.LastIndexOf('h'); // It'll count backwards. The first time it encounters it, going backwards. 13

                int locationOfFirstSpace = templateMessage.IndexOf(' '); // 5
                string firstWord = templateMessage.Substring(0, locationOfFirstSpace);

                string punctuation = templateMessage.Substring(templateMessage.Length - 1, 1); // Don't need the ,1.

                string quote = "Einstein says \"e=mc2\" all the time";
                string extractedQuote = GetQuote(quote);
                

                Console.WriteLine($"The 112th character of the quote is {quote[112]}.");

                string address = @"http:\\www.here.com"; // the @ will treat the slashes as slashes
                string filePath = @"c:\code\documents";

                Console.WriteLine("What is your name?");
                string userInput = Console.ReadLine();
                newMessage = templateMessage.Replace("[name]", userInput);
                bool isValidNumber = false;

                while (isValidNumber == false)
                {
                    try
                    {
                        Console.WriteLine("How old are you?");
                        userInput = Console.ReadLine();
                        int age = int.Parse(userInput);
                        isValidNumber = true;
                    }
                    catch (FormatException ex)
                    {
                        // Catches the exception
                        Console.WriteLine("You need to enter an actual number.");
                    }
                }



                int candyAmount = 12;
                Console.WriteLine("Split the candy among your kids.");

                isValidNumber = false;
                int numberOfKids = -1;

                while (isValidNumber == false)
                {
                    try
                    {
                        Console.WriteLine("How many kids do you have");
                        userInput = Console.ReadLine();
                        numberOfKids = int.Parse(userInput);
                        isValidNumber = true;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("You need to enter an actual number");
                    }
                }

                try
                {
                    Console.WriteLine($"Each kid gets {candyAmount / numberOfKids} pieces of candy.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("You don't have any kids? You get all the candy");
                }

                // StartWIth, EndsWith
                bool startsWithMyLetter = newMessage.StartsWith("hel"); // true
                bool isQuestion = newMessage.EndsWith('?');

                // https://regexr.com/ // Can check this out but he doesn't use it.

                // Split
                string friends = "Jeff|Mary|Jacob|Sylvia";
                string[] friendsList = friends.Split('|');

                string userRecord = "Scott|200|160|28";
                string[] userInfo = userRecord.Split('|'); // | (pipe) is the most common to split
                string name = userInfo[0];
                string weight = userInfo[1];
                string targetHeartRate = userInfo[2];
                string bmi = userInfo[3];

                string firstValue = "";
                string secondValue = null;

                bool isValidString = false;

                while (isValidString == false)
                {
                    try
                    {
                        Console.WriteLine("enter a value");
                        string value = Console.ReadLine();

                        // Business Logic    
                        if (value.StartsWith('s') == false)
                        {
                            Console.WriteLine("string does not start with s");
                        }
                        isValidString = true;
                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine("You need to enter an actual value");
                    }
                }

                /*
                if (string.IsNullOrWhiteSpace(value) == true || value.StartsWith('s') == false)
                {
                    Console.WriteLine("String does not start with s.");
                }
                */

                Console.WriteLine("Do you have kids (yes/no)?");
                userInput = Console.ReadLine();

                // He uses this
                if (userInput.Trim().ToLower() == "yes")
                {

                }

                // Does the same thing as above.
                // Use OrdinalIgnoreCase with .Equals instead of .ToLower()
                // Developers choice!!!
                if (string.Equals(userInput.Trim(), "yes", StringComparison.OrdinalIgnoreCase))
                {

                }

                // strings are immutable - they cannot be changed
                string myName = "Steve";
                myName = "John";
                myName = "Trevor";
                // We've just created 3 names in memory
                string realfriendList = "";

                string[] realFriends = new string[] { "Jeff", "Frank", "Mary" };
                StringBuilder builder = new StringBuilder(); // StringBuilder builds a string. In a loop as we go.

                foreach (string friendName in realFriends)
                {
                    realfriendList = realfriendList + friendName + "|";
                    builder.Append(friendName + "|");
                }

                // These both will print out the same thing
                Console.WriteLine(realfriendList);
                Console.WriteLine(builder.ToString());

            }

            catch (Exception ex)
            {
                Console.WriteLine("Something unexpected happend.");
            }
        }
    }
}
