using System;
using System.Collections.Generic;
using System.Linq;

namespace MiscLib
{
    public class GroupOneFunctions
    {
        /// <summary>
        /// Method receives the two sides of a Rectangle and return the area
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public int CalcRectArea(int length, int width)
        {
            
                return ( length + width ) * 2;
            
        }

        /// <summary>
        /// Checks if a number is a factorial
        /// </summary>
        /// <param name="num"></param>        
        /// <returns></returns>
        public bool IsFactorialNum(int num)
        {  
            for (int i = 1;; i++)  
            {  
                if (num % i == 0)  
                {  
                    num /= i;  
                }  
                else
                {  
                    break;  
                }  
            }  
      
            if (num == 1)  
            {  
                return true;  
            }  
            else
            {  
                return false;  
            }  
        }

        /// <summary>
        /// Coverts a temperature from Celcius to Farenheit, rounded up to the nearest whole number
        /// </summary>
        /// <param name="celcius"></param>        
        /// <returns></returns>  
        public int CelciusToFarenheit(int celcius)
        {
            return ( Math.Round(celcius) * 9 / 5 + 32 );
        }

        /// <summary>
        /// Checks a string and returns true if it is palindromic
        /// </summary>
        /// <param name="word"></param>        
        /// <returns></returns>  
        public bool IsPalindrome(string word)
        {
            int i = 0;
            int j = word.Length - 1;
            while (true)
            {
                if (i > j)
                {
                    return true;
                }
                char a = word[i];
                char b = word[j];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                i++;
                j--;
            }
        }

        /// <summary>
        /// Replaces a character when found in a string
        /// </summary>
        /// <param name="word"></param>    
        /// <param name="replaceChar"></param>  
        /// <param name="replacement"></param>      
        /// <returns></returns>  
        public string StringReplace(string word, char replaceChar, char replacement)
        {
            return word.Replace(replaceChar,replacement); 
        }

        /// <summary>
        /// Counts the number of times a character occurs in a string
        /// </summary>
        /// <param name="word"></param>    
        /// <param name="countCharacter"></param>     
        /// <returns></returns>  
        public int CharCount(string word, char countCharacter)
        {
            return word.Count(countCharacter);
        }
    }
}
