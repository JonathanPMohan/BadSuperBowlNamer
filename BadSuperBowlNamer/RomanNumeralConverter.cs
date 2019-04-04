using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BadSuperBowlNamer
{
    public class RomanNumeralConverter
    {
        public string NumberConvertToRoman(string numberToConvert)
        {
            try
            {
                var newNumber = numberToConvert;
                var convertedNumber = "I";

                return convertedNumber;
            }
            catch (FormatException)
            {
                throw new InvalidInputException();
            }
        }
    }
}
