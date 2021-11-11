using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    public interface IEggLayer // has to have IncubationTime and LayEggs(). Can't have fields
    {
        int IncubationTime { get; set; }

        bool LayEggs();
    }
}
