using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    public static class ExceptionManager
    {
        public static void LogException(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        public static void LogException(Exception ex, DateTime timeOccurred)
        {
            Console.WriteLine($"{ex.Message},{timeOccurred}");
        }

        public static void LogException(Exception ex, DateTime timeOccurred, string userName)
        {
            Console.WriteLine($"{ex.Message},{timeOccurred}, {userName}");
        }
    }
}
