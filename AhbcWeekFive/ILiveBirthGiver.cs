using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    public interface ILiveBirthGiver // Anyone using this interface must use GiveLiveBirth()
    {
        // don't need public or abstract because it's implied (has to be public and abstract)
        void GiveLiveBirth();
    }
}
