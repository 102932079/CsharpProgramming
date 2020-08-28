using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {
        // Write Unit Tests for all functions for your assigned group
        // Group 1

        // 1. Method receives the two sides of a Rectangle and return the area CalcRectArea(int length, int width) : int

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(12, 3, 4)]
               
        public int CalcRectArea(int expected, int length, int width)
        {
            GroupOneFunctions g1 = new GroupOneFunctions(length, width);
            Assert.Equal(expected, g1.CalcRectArea());
        }

        // 2. Checks if a number is a factorial IsFactiorialNum(int num) : bool

        [Theory]
        [InlineData(true, 120)]
        [InlineData(true, 720)]
        [InlineData(false, 250)]
        [InlineData(false, 999)]
        
        public bool IsFactiorialNum(bool expected, int num)
        {
            GroupOneFunctions g1 = new GroupOneFunctions(num);
            Assert.Equal(expected, g1.IsFactiorialNum());
        }

        // 3. Converts a temperature from Celcius to Farenheit, rounded up to the nearest whole number CelciusToFarenheit(int celcius) : int

        [Theory]
        [InlineData(32, 0)]
        [InlineData(212, 100)]
        [InlineData(-148, -100)]
        public int CelciusToFarenheit(int expected, int celcius)
        {
            GroupOneFunctions g1 = new GroupOneFunctions(celcius);
            Assert.Equal(expected, g1.CelciusToFarenheit());
        }

        // 4. Checks a string and returns true if it is palindromic IsPalindrome(string word) : bool

        [Theory]
        [InlineData(true, "abcba")]
        [InlineData(true, "aaaaa")]
        [InlineData(false, "abcdef")]
        [InlineData(false, "abcbc")]
        
        public bool IsPalindrome(bool expected, string word)
        {
            GroupOneFunctions g1 = new GroupOneFunctions(word);
            Assert.Equal(expected, g1.IsPalindrome());
        }

        // 5. Replaces a character when found in a string StringReplace(string word, char replaceChar, char replacement) : string

        [Theory]
        [InlineData("dbc", "abc", "a", "d")]
        [InlineData("oyz", "xyz", "x", "o")]    
       

        public string StringReplace(string expected, string word, char replaceChar, char replacement)
        {
            GroupOneFunctions g1 = new GroupOneFunctions(word, replaceChar, replacement);
            Assert.Equal(expected, g1.StringReplace());
        }

        // 6. Counts the number of times a character occurs in a string CharCount(string word, char countCharacter) : int
        
        [Theory]
        [InlineData(5, "aaaaa", "a")]
        [InlineData(0, "zzzzz", "a")]    
        
        public int CharCount(int expected, string word, char countCharacter)
        {
            GroupOneFunctions g1 = new GroupOneFunctions(word, countCharacter);
            Assert.Equal(expected, g1.CharCount());
        } 

    
    }
}
