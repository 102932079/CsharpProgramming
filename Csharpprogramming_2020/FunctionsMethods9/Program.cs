/*
9. Write a program in C# Sharp to create a function to check whether a number is prime or not. 
Test Data : 
Input a number : 31 
Expected Output : 
31 is a prime number
*/

using System;

namespace FunctionsMethods9
{
    class Program
    {
       public static bool checkprime(int number)
       {
          for (int i=2; i < number; i++)
          if (number % i == 0) 
          return false;
          return true;
       }
       public static void Main()
       {
	     
	     Console.WriteLine("Input a number : ");

         int a = int.Parse(Console.ReadLine());	
	
         if (checkprime(a))
           Console.WriteLine( a + " is a prime number");

         else
           Console.WriteLine( a + " is not a prime number");
         
         Console.ReadKey();
        }
    }   
}
