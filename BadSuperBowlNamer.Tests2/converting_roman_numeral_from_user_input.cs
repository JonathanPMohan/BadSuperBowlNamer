using System;
using Xunit;

namespace BadSuperBowlNamer.Tests
{
    public class converting_roman_numeral_from_user_input

    {
        [Fact]
        public void convert_number_1_to_I()
        {
            // Arrange -- Context              -- Given
            var convert = new RomanNumeralConvertor();
            var input = 1;
            var expectedResult = "I";

            // Act     -- Do the thing         -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_5_to_V()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 5;
            var expectedResult = "V";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_9_to_IX()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 9;
            var expectedResult = "IX";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}