using System;
using System.Collections.Generic;
using System.Linq;

namespace MiscLib
{
    //---- Group 2 Functions ----------
    public class GroupTwoFunctions
    {
        
        /// <summary>
        /// 1.  Method receives the two sides of a Rectangle and return the perimeter
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <returns>int</returns>
        public int CalcRectPerimeter( int length , int width )
        {
            return ( length + width ) * 2;
        }

        /// <summary>
        /// 2.  Checks if a number is a triangular number
        /// </summary>
        /// <param name="num"></param>      
        /// <returns>bool</returns>
        public bool IsTriangularNum( int num )
        {
            long calc_num = 8 * num + 1;
            long t = ( long ) Math.sqrt ( calc_num );

            if ( t * t == calc_num )
            {
                return true;
            }         
            
            return false;
            
        }

        /// <summary>
        /// 3.  Coverts a temperature from Farenheit to Celcius, rounded up to the nearest whole number
        /// </summary>
        /// <param name="farenheit"></param>      
        /// <returns>int</returns>
        public int FarenheitToCelcius( int farenheit ) 
        {
            int celsius = ( Math.Round(farenheit) - 32 ) * 5 / 9 ;
            return celsius;
        }

        /// <summary>
        /// 4.  Checks a string for either leading or trailing white spaces
        /// </summary>
        /// <param name="word"></param>      
        /// <returns>bool</returns>
        public bool CheckWhiteSpace( string word )
        {
            int numberOfSpaces = 0;

            for ( int i = 0 ; i < word.length ; i++ )
            {
                if ( wird[i] == ' ' )
                {
                    numberOfSpaces++;
                }
            }

            if( numberOfSpaces >= 1 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 5.  Takes a string and makes every odd letter uppercase and every even letter lowercase
        /// </summary>
        /// <param name="word"></param>      
        /// <returns>string</returns>
        public string CamelString( string word ) 
        {
           string ConvertWord = string.Empty;
           for ( int i = 0 ; i < word.length ; i++ )
           {
               if ( i % 2 == 0 )
               {
                    ConvertWord = ConvertWord + word[i].Tostring().ToUppe();
               }
               else
               {
                   ConvertWord = ConvertWord + word[i].Tostring().ToLower();
               }
           }

           return ConvertWord;
        }

        /// <summary>
        /// 6.  Counts the number of digits found in a string
        /// </summary>
        /// <param name="word"></param>      
        /// <returns>int</returns>
        public int CountDigits( string word ) 
        {
            int i = 0;
            int l = word.length;
            int digit = 0;

            while ( i < l )
            {
                if ( word[i] >= '0' && word[i] <= '9' )
                {
                    digit++;
                }
                i++;
            }
            return digit;
           
        }

        
    }
}
