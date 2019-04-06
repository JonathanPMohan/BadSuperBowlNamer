using System;
using Xunit;

namespace BadSuperBowlNamer.Tests
{
    public class converting_roman_numeral_from_user_input

    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(9, "IX")]
        [InlineData(12, "XII")]
        [InlineData(16, "XVI")]
        [InlineData(29, "XXIX")]
        [InlineData(44, "XLIV")]
        [InlineData(45, "XLV")]
        [InlineData(68, "LXVIII")]
        [InlineData(83, "LXXXIII")]
        [InlineData(97, "XCVII")]
        [InlineData(99, "XCIX")]
        [InlineData(500, "D")]
        [InlineData(501, "DI")]
        [InlineData(649, "DCXLIX")]
        [InlineData(798, "DCCXCVIII")]
        [InlineData(891, "DCCCXCI")]
        [InlineData(1000, "M")]
        [InlineData(1004, "MIV")]
        [InlineData(1006, "MVI")]
        [InlineData(1023, "MXXIII")]
        [InlineData(2014, "MMXIV")]
        [InlineData(3999, "MMMCMXCIX")]

        public void convert_number_to_roman_numeral(int input, string expectedResult)
        {
            // Arrange -- Context              -- Given
            var convert = new RomanNumeralConvertor();

            // Act     -- Do the thing         -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

    }
}