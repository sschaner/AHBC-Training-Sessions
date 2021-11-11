using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    public static class ExportDataManager
    {
        // Most of the time, the types will match but don't have to

        public static void ExportData(string data, string fileName)
        {
            // Logic to write to a file
        }

        public static void ExportData(string data, DataRepository dataRepository)
        {
            // Logic to write data to a database
        }


        public static DataRepository ExportData(string data)
        {
            // Logic to write data to a database
            DataRepository database = new DataRepository();
            // Write to database
            // Return repository object
            return database;
        }
    }
}
