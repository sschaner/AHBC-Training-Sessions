using System;

namespace AhbcWeekFive
{
    class Program
    {
        static void Main(string[] args)
        {


            // Animal newAnimal = new Animal();

            Dog myDog = new Dog();
            myDog.Name = "Memphis";
            myDog.Age = 5;
            myDog.FoodType = "Peanut Butter Dog Food";
            myDog.FurType = "Hair";
            myDog.Grow(12); // Increasing height (base class functionality)
            myDog.Sleep(8, "The floor");
            ExecuteBirthingMethod(myDog);

            Fish thisFish = new Fish() { Name = "red fish" };
            thisFish.WaterType = "Fresh Water";
            thisFish.Grow(2); // Increasing length (derived class functionality)
            thisFish.IncubationTime = 20;
            ExecuteBirthingMethod(thisFish);

            BoaConstrictor boa = new BoaConstrictor() { IncubationTime = 10 };
            ExecuteBirthingMethod(boa);
            FinnishLapphund myDog2 = new FinnishLapphund();
            myDog2.AwesomenessLevel = 10000000;
            ExecuteBirthingMethod(myDog2);

            DisplayIncubationTime(boa);
            DisplayIncubationTime(thisFish);
            // DisplayIncubationTime(myDog2); // This won't work because myDog2 does not implement IEggLayer

            try
            {
                int zero = 0;
                int calc = 12 / zero;
            }
            catch (DivideByZeroException ex)
            {

                ExceptionManager.LogException(ex, DateTime.Now, "sschaner");
            }

            ExportDataManager.ExportData(@"C:\Code");

            DataRepository newRepo = new DataRepository();
            newRepo.DatabaseName = "ThisTable";
            ExportDataManager.ExportData("data", newRepo);
            // This is the same as above but just inline
            ExportDataManager.ExportData("data", new DataRepository { DatabaseName = "ThatTable", ServerName = "ThisServer" });
        }

        public static int ValidateInteger(string input)
        {
            int validInt = -1;
            bool isValid = int.TryParse(input, out validInt);
            CheckRange(input);
            return validInt;
        }

        public static bool CheckRange(string input)
        {
            return true;
        }

        public static void DisplayEggLayerStuff(IEggLayer eggLayer)
        {
            if (eggLayer.LayEggs() == true)
            {
                Console.WriteLine(eggLayer.IncubationTime);
            }            
        }

        // Can pass in any object you want, as long as it implements IEggLayer
        public static void DisplayIncubationTime(IEggLayer eggLayer)
        {
            Console.WriteLine(eggLayer.IncubationTime);
        }

        public static void ExecuteBirthingMethod(ILiveBirthGiver animal)
        {
            Console.WriteLine("You have given live birth.");
        }

        public static void ExecuteBirthingMethod(IEggLayer animal)
        {
            Console.WriteLine($"You have laid eggs.");
        }

    }
}
