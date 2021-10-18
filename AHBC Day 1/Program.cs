using System;

namespace AHBC_Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            // While and Do...While
            // both have a condition check

            // Will execute the code until the condition changes.
            int number = 15;
            bool exitApplication = false;
            bool numberIsBad = true;
            int userNumber = -1;
            bool isCorrectAnswer = false;
            bool playAgain = true;



            for (int counter = 10; counter >= 0; counter--)
            {
                Console.WriteLine(counter);
            }

            do // Loop to play again
            {
                for (int counter = 1; counter < 11; counter++)
                {
                    Console.WriteLine($"Guess Number: {counter}");
                    numberIsBad = true;

                    while (numberIsBad == true)
                    {
                        Console.WriteLine("Pick a number from 1 - 20");
                        userInput = Console.ReadLine();
                        userNumber = int.Parse(userInput);
                        if (userNumber > 20 || userNumber < 1)
                        {
                            // Fix bad number
                            Console.WriteLine("bad number, try again.");
                        }
                        else
                        {
                            numberIsBad = false;
                        }
                    }

                    if (userNumber == number)
                    {
                        isCorrectAnswer = true;
                        Console.WriteLine("Yeah you guessed it.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!!! Guess again.");
                    }
                }
                if (isCorrectAnswer == false)
                {
                    Console.WriteLine("You have run out of turns.");
                }

                Console.WriteLine("play again");
                userInput = Console.ReadLine();
                if (userInput.Trim().ToLower() == "no")
                {
                    playAgain = false;
                }

            } while (playAgain == true);

            Console.ReadKey();


            do
            {
                Console.WriteLine("Hey there");
                Console.WriteLine("Go again? Anything besides yes will exit the code.");
                userInput = Console.ReadLine();

                if (userInput.ToLower().Trim() == "yes")
                {
                    exitApplication = true;
                }
                else
                {
                    exitApplication = false;
                }
            } while (exitApplication == false);

            while (number == 1)
            {
                number = 2;
            }

            //  Welcome();
        }


        static void Welcome()
        {
            Console.WriteLine("What section do you want to run?");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    goto GetName;
                    break;
                case 2:
                    goto GetAge;
                    break;
                case 3:
                    goto UserBankBalance;
                    break;
                case 4:
                    goto EmotionalCheckup;
                    break;
                default:
                    goto Exit;
            }

        /*
        if (selection == 1)
        {
            goto GetName;
        }
        else if (selection == 2)
        {
            goto GetAge;
        }
        else if (selection == 3)
        {
            goto UserBankBalance;
        }
        else if (selection == 4)
        {
            goto EmotionalCheckup;
        }
        else
        {
            goto Exit;
        }
        */


        GetName:

            Console.WriteLine("Hello world");

            // This is a normal comment
            // TODO - Fix this later
            // HACK - smelly code

            // Get user name
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            string userInput = "";

            const string COMPUTERNAME = "HAL";

            Console.WriteLine(COMPUTERNAME);

            goto Exit;

        GetAge:

            // Get age
            Console.WriteLine("How old are you?");
            userInput = Console.ReadLine();

            // Convert userAge to Integer
            int userAge = int.Parse(userInput);

            // bool isOldEnough = userAge > 20;
            bool isOldEnough = false;
            string country = "";

            if (userAge >= 21)
            {
                Console.WriteLine("Welcome to the bar, have a drink.");
            }
            else if (userAge == 19 && country == "canada")
            {
                Console.WriteLine("Have a drink, eh!");
            }
            else if (userAge > 17 && userAge < 21)
            {
                Console.WriteLine("You can only dance.");
            }
            else
            {
                Console.WriteLine("No Dice.");
            }




            if (country == "us")
            {
                if (userAge >= 21)
                {
                    Console.WriteLine("Welcome to the bar, have a drink.");
                }
                else if (userAge > 17 && userAge < 21)
                {
                    Console.WriteLine("You can only dance.");
                }
                else
                {
                    Console.WriteLine("No Dice.");
                }
            }

            if (country == "canada")
            {
                if (userAge >= 19)
                {
                    Console.WriteLine("Welcome to the bar, have a drink.");
                }
                else if (userAge > 17 && userAge < 19)
                {
                    Console.WriteLine("You can only dance.");
                }
                else
                {
                    Console.WriteLine("No Dice.");
                }
            }

            if (userAge > 17 && userAge < 21)
            {
                Console.WriteLine("You are only allowed to dance.");
            }

            if (userAge < 18)
            {
                Console.WriteLine("No Dice.");
            }



            if (isOldEnough != false)
            {
                // This code WILL NOT run
            }

            if (isOldEnough == true)
            {
                // This WILL NOT run
            }

            userAge--; // Same as userAge = userAge + 1

            userAge = userAge + 10; // same as userAge += 10

            int answer = userAge % 3; // divides by 3 and gives the remainder

            goto Exit;

        EmotionalCheckup:

            Console.WriteLine("How are you feeling today?");
            userInput = Console.ReadLine();
            userInput = "    sad   ";

            switch (userInput.ToLower().Trim())
            {
                case "sad":
                case "unhappy":
                case "crying":
                    if (userInput.ToLower().Trim() == "crying")
                    {
                        Console.WriteLine("Please don't cry.");
                    }
                    Console.WriteLine("I'm sorry you're not feeling great.");
                    break;
                case "happy":
                    Console.WriteLine("Yay! That's awesome!");
                    goto UserBankBalance;
                    break;
                case "confused":
                    Console.WriteLine("I get that way too.");
                    break;
                default:
                    Console.WriteLine("I don't know what that means.");
                    break;
            }

            //if (userInput.ToLower().Trim() == "sad")
            //{

            //}
            //else if (userInput == "happy")
            //{

            //}
            //else
            //{

            //}

            goto Exit;

        UserBankBalance:

            // Decimal values
            Console.WriteLine("What is your banking balance (No $ sign)?");
            userInput = Console.ReadLine();
            // Convert balance to double
            double userBankBalance = double.Parse(userInput);

            // Convert double to int (It wont' round but drop digits after decimal point)
            // int dollarAmount = Convert.ToInt32(userBankBalance); // Not often used
            int dollarAmount = (int)userBankBalance; // See this more often. Cast as an int

            // string message = "You have" + userBankBalance + "in your account.";

            string message = $"You have {userBankBalance} in your account. Richness is {userBankBalance >= 1000}";

            Console.WriteLine(message);


        // Subtract their age from mine



        // Ask for half their money

        // Display the difference

        Exit:

            Console.ReadKey();

            /*
            Multi-line comment
            Multi-line comment
            Multi-line comment
            Multi-line comment
             */
        }
    }
}
