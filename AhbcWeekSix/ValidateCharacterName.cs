using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekSix
{
    public class ValidateCharacterName : Character
    {
        public static  bool ValidateName(string value)
        {
            if (ValidateName(value) == false)
            {
                CharacterName = "invalid";
                return true;
            }
            else
            {
                CharacterName = value;
                return false;
            }

            return value;
        }


    }
}
