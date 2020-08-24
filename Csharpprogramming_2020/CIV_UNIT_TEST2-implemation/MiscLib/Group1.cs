using System;

namespace MiscLib
{
    public class GroupOneFunctions
    {
        //---- Group 1 Functions ----------
        public int CalcRectArea(int length, int width)
        {
            if ((length > 0) & (width > 0))
            {
                int RESULT = 2 * (length + width);
                return RESULT;
            }
            else
            {
                return 0;
            }
        }

        public bool IsFactiorialNum(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if ((num % i) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
             return false;
        }

        public int CelciusToFarenheit(int celcius)
        {
            int Farenheit = ((celcius * 9 / 5) + 32);
            return Farenheit;
        }

        public bool IsPalindrome(string word)
        {
            string first = word.Substring(0, word.Length / 2);
            Char[] array = word.ToCharArray(0,word.Length);
            Array.Reverse(array);
            string reverseword = array.ToString();
            string second = reverseword.Substring(0, reverseword.Length / 2);
            return first.Equals(second);

        }

        public string StringReplace(string word, char replaceChar, char replacement)
        {
            Char[] arrays = word.ToCharArray(0,word.Length);
            if (Array.Exists(arrays, element => element == replaceChar) ==false)
            {
                return "The char doesn't exit in the string";
            }
            else
            {
                arrays[Array.IndexOf(arrays, replaceChar)] = replacement;
                string newword = arrays.ToString();
                return newword;
            }
        }

        public int CharCount(string word, char countCharacter)
        {
            int digitsCount = 0;
            foreach (char c in word)
            {
                if (c==countCharacter)
                    digitsCount++;
            }
            return digitsCount;
        }


    }
}
