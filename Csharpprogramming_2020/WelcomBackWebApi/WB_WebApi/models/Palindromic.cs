// Welcome Back: Task 1
// A palindromic number reads the same both ways.
// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
// Create a program that finds the lowest and largest palindromic numbers for a user given number of digits.
// Adapted from:  https://projecteuler.net/problem=4
// solution https://www.youtube.com/watch?v=nN05TQ8vew8

using System;
using System.Collections.Generic;
using System.Linq;

namespace models
{
    public class palindromic
    {
        //user giving number number
        public bool palindromeCheck(int number)
        {
            //this function turns the int into a char array and reversese using LINQ built in functions
            string resultHolder;

            resultHolder = number.ToString();
            //The toString() method returns a string representing the object.

            var forwardArray = resultHolder.ToCharArray();
            //The method toCharArray() returns an Array of chars after converting a String into sequence of characters. 

            var reversArray = forwardArray.Reverse().ToArray();    
            //The toArray() method of ArrayList is used to return an array containing all the elements in ArrayList in the correct order.
            //everse() method is used for in-place reversal of the array

            var isPalindrome = Enumerable.SequenceEqual(forwardArray, reversArray);
            //Determines whether two sequences are equal according to an equality comparer.
            
            return isPalindrome;
        }

        public int PalindromeMin(int num)
        {
            double initmaxValue;
            double initminValue;

            List<int> resultsList = new List<int>();

            initmaxValue = Math.Pow(10, (num)) - 1;
            //Returns a specified number raised to the specified power.
            initminValue = Math.Floor(1 + initmaxValue / 10);
            //The Math.floor() function returns the largest integer less than or equal to a given number.

            int maxValue = Convert.ToInt32(initmaxValue);

            int minValue = Convert.ToInt32(initminValue);

            // get two numbers which are the minimum for num x 2
            int result = 0;

            for (int i = maxValue; i > minValue; i--)
            {
                for (int j = maxValue; j > minValue; j--)
                {
                    result = i * j;
                    bool test = palindromeCheck(result);

                    if (test)
                    {
                        resultsList.Add(result);
                        //add to the palindrom list
                    }
                }
            }
            int outputMin;
            int outputMax;

            outputMin = resultsList.Min();
            outputMax = resultsList.Max();

            return outputMin;            
        }

        public int PalindromeMax(int num)
        {
            double initmaxValue;
            double initminValue;

            List<int> resultList = new List<int>();

            initmaxValue = Math.Pow(10, (num)) - 1;
            initminValue = Math.Floor(1 + initmaxValue / 10);

            int maxValue = Convert.ToInt32(initmaxValue);
            int minValue = Convert.ToInt32(initminValue);

            //get two number which are the minimum for num x 2
            int result = 0;

            for (int i = maxValue; i > minValue; i--)
            {
                for (int j = maxValue; j > minValue; j--)
                {
                    result = i * j;
                    bool test = palindromeCheck(result);

                    if (test)
                    {
                        resultsList.Add(result);
                        //add to list
                    }
                }
            }
            int outputMax;
            int outputMin;

            outputMax = resultList.Max();
            outputMin = resultList.Min();

            return outputMax;

        }

        
    }
}