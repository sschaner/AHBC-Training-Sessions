using CollectionManager.Interactors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Coral blueNest = new Coral()
            {
                Name = "Blue Nest SPS",
                Description = "Looks like a tree.",
                Price = 4567
            };

            Coral redBlasto = new Coral()
            {
                Name = "Rose Blasto",
                Description = "Red and fleshy.",
                Price = 6000,
                Weight = 1.5
            };

            List<Coral> edCollection = new List<Coral>();
            edCollection.Add(blueNest);
            edCollection.Add(redBlasto);

            ComicFigurine squirrelGirl = new ComicFigurine()
            {
                Name = "Squirrel Girl",
                Description = "One of Great Lake Avengers",
                Price = 56000
            };

            ComicFigurine jessJones = new ComicFigurine()
            {
                Name = "Jessica Jones",
                Description = "Bad ass woman",
                Price = 100000
            };

            ComicFigurine[] aprilsCollection = new ComicFigurine[] { squirrelGirl, jessJones };
            CollectionInteractor.DisplayItem(jessJones);
            CollectionInteractor.DisplayAllItems(aprilsCollection);
            Console.WriteLine(CollectionInteractor.GetTotalAmountSpent(aprilsCollection));

            Console.WriteLine();
            Console.WriteLine();

            CollectionInteractor.DisplayItem(blueNest);
            CollectionInteractor.DisplayAllItems(edCollection);
            Console.WriteLine(CollectionInteractor.GetTotalAmountSpent(edCollection));
            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }

        
    }
}
