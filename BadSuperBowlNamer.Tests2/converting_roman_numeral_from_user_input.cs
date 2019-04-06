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

        [Fact]
        public void convert_number_12_to_XII()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 12;
            var expectedResult = "XII";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_16_to_XVI()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 16;
            var expectedResult = "XVI";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_29_to_XXIX()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 29;
            var expectedResult = "XXIX";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_44_to_XLIV()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 44;
            var expectedResult = "XLIV";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_45_to_XLV()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 45;
            var expectedResult = "XLV";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_68_to_LXVIII()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 68;
            var expectedResult = "LXVIII";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_83_to_LXXXIII()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 83;
            var expectedResult = "LXXXIII";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_97_to_XCVII()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 97;
            var expectedResult = "XCVII";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_99_to_XCIX()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 99;
            var expectedResult = "XCIX";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_500_to_D()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 500;
            var expectedResult = "D";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_501_to_DI()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 501;
            var expectedResult = "DI";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_649_to_DCXLIX()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 649;
            var expectedResult = "DCXLIX";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_798_to_DCCXCVIII()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 798;
            var expectedResult = "DCCXCVIII";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_891_to_DCCCXCI()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 891;
            var expectedResult = "DCCCXCI";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_1000_to_M()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 1000;
            var expectedResult = "M";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_1004_to_MIV()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 1004;
            var expectedResult = "MIV";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_1006_to_MVI()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 1006;
            var expectedResult = "MVI";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void convert_number_1023_to_MXXIII()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 1023;
            var expectedResult = "MXXIII";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_2014_to_MMXIV()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 2014;
            var expectedResult = "MMXIV";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_number_3999_to_MMMCMXCIX()
        {
            // Arrange - Context                 -- Given
            var convert = new RomanNumeralConvertor();
            var input = 3999;
            var expectedResult = "MMMCMXCIX";

            // Act      -- Do the thing  --       -- When
            var actualResult = convert.ConvertToRoman(input);

            // Assert - checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}