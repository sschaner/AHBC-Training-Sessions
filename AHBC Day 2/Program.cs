using System;

namespace AHBC_Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Method

            // ToLower - ToUpper
            // TrimStart - TrimEnd - Trim

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


            Console.WriteLine("What is your name?");
            string userInput = Console.ReadLine();
            newMessage = templateMessage.Replace("[name]", userInput);

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


            Console.ReadKey();
        }
    }
}
