using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CollectionManager.Interactors
{
    public static class CollectionInteractor
    {
        public static void DisplayItem(ICollectable item)
        {
            Console.WriteLine($"{item.Name} - {item.Description} - {item.Price}");
        }

        public static ICollectable GetItem(IEnumerable<ICollectable> collection, string name)
        {
            return collection.Where(x => x.Name == name).First();
        }

        public static void DisplayAllItems(IEnumerable<ICollectable> collection)
        {
            // OrderBy is temporary
            IEnumerable<ICollectable> sortedList = collection.OrderBy(x => x.Name);

            foreach (ICollectable item in sortedList)
            {
                Console.WriteLine($"{item.Name} - {item.Description} - {item.Price}");
            }
        }

        public static double GetTotalAmountSpent(IEnumerable<ICollectable> collection)
        {
            return collection.Select(x => x.Price).Sum();
        }

        //public static void AddNewItem(ICollection collection, ICollectable item)
        //{
        //    collection.Add(item);
        //}
    }
}
