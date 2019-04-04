using System;
using Xunit;

namespace BadSuperBowlNamer.Tests
{
    public class converting_roman_numeral_from_user_input
   
    {
        [Fact]
        public void convert_number_1_to_I()
        {
            //Arrange -- Context              -- Given
            var convert = new RomanNumeralConverter();
            var input = "1";
            var expectedResult = "I";

            //Act     -- Do the thing         -- When
            var actualResult = convert.NumberConvertToRoman(input);

            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}