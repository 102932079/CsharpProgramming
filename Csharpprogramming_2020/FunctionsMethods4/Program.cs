/*
4. Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string. 
Test Data : 
Please input a string : This is a test string. 
Expected Output : 
"This is a test string." contains 4 spaces
*/

using System;

namespace FunctionsMethods4
{
    class Program
    {
        public static int Count(string str)
	    {   
		int spcctr=0;
		string str1;
		for (int i = 0;i < str.Length;i++)
			{
			  str1 = str.Substring(i,1);
			  if (str1 == " ")
			  spcctr++;
			}
		return spcctr;
	    }
        public static void Main()
	    {
	    string str2;
		Console.Write("Please input a string : ");
        str2 = Console.ReadLine();
		Console.WriteLine(str2 + " contains " + Count(str2) + " spaces" );

        Console.ReadKey();
        
	    }    
    }
}
