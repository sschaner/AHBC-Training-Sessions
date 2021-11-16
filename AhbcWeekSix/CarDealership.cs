using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekSix
{
    public class CarDealership
    {
        public List<ICar> CarInventory  { get; set; }
        public List<IPerson> Employees { get; set; }
        public List<IPerson> Customers { get; set; }
        private ICar carObject;

        public CarDealership(ICar car)
        {
            carObject = car;
        }

        public ICar GetCheapestCar()
        {
            return carObject;
        }

        public List<string> GetNames(List<IPerson> list)
        {
            List<string> returnList = new List<string>();
            foreach (IPerson item in list)
            {
                returnList.Add($"{item.FirstName} {item.LastName}");
            }

            return returnList;
        }
    }
}
