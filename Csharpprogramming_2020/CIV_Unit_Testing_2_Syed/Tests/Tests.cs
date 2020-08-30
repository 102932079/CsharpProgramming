using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {
        // Write Unit Tests for all functions for your assigned group
        GroupTwoFunctions x = new GroupTwoFunctions();

        // 1.  Method receives the two sides of a Rectangle and return the perimeter
        [Theory]
        [Inlinedata(18, 5, 4)]
        [Inlinedata(20, 7, 3)]
        public void CalcRectPerimeter_Test(int expected, int length, int width) {
            Assert.Equal(expected, x.CalcRectPerimeter(length, width));
        }

        // 2.  Checks if a number is a triangular number
        [Theory]
        [Inlinedata(true, 6)]
        [Inlinedata(false, 7)]
        public void IsTriangularNum_Test(bool expected, int num) {
            Assert.Equals(expected, x.IsTriangularNum(num));
        }

        // 3.  Coverts a temperature from Farenheit to Celcius, rounded up to the nearest whole number
        [Theory]
        [Inlinedata(7, 44)]
        [Inlinedata(2, 35)]
        public void FarenheitToCelcius_Test(int expected, int farenheit) {
            Assert.Equal(expected, x.FarenheitToCelcius(farenheit));
        }

        // 4.  Checks a string for either leading or trailing white spaces
        [Theory]
        [Inlinedata(true, "Syed ")]
        [Inlinedata(false, " Razvi")]
        public void CheckWhiteSpace_Test(bool expected, string word) {
            Assert.Equals(expected, x.CheckWhiteSpace(word));
        }

        // 5.  Takes a string and makes every odd letter uppercase and every even letter lowercase
        [Theory]
        [Inlinedata("HeLlOwOrLd", "HelloWorld")]
        [Inlinedata("AnGuLaR", "angular")]
        public void CamelString_Test(string expected, string word) {
            Assert.Equal(expected, x.CamelString(word));
        }

        // 6.  Counts the number of digits found in a string
        [Theory]
        [Inlinedata(3, "1234")]
        [Inlinedata(5, "98765")]
        public void CountDigits_Test(int expected, string word) {
            Assert.Equal(expected, x.CountDigits(word));
        }

    }
}
