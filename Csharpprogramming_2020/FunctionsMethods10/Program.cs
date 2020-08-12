/*
10. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. 
Test Data : 
Enter a number: 1234 
Expected Output : 
The sum of the digits of the number 1234 is : 10
*/
using System;
public class funcexer10
{     
public static int Sumofdigits( int a ) 
    { 
       string b = Convert.ToString(a);
       int total = 0;  
       for (int i = 0; i < b.Length; i++)
         total += int.Parse(b.Substring(i,1));
       return total;
    }
 
public static void Main() 
    {
	  int number;

      Console.Write("Enter a number: ");
      number = int.Parse( Console.ReadLine() );
      Console.WriteLine("The sum of the digits of the number " + number + " is : " + Sumofdigits(number));   
      Console.ReadKey();

    }
}
