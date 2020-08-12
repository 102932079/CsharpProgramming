/*
7. Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another. 
Test Data : 
Input Base number: 3 
Input the Exponent : 2 
Expected Output : 
So, the number 3 ^ (to the power) 2 = 9
*/
using System;

namespace FunctionsMethods7
{
    class Program
    {
        public static void Main()
        {
          int base1;
          int exponent1;

	      Console.Write("Input Base number: ");
          base1= int.Parse(Console.ReadLine());
          Console.Write("Input the Exponent : ");
          exponent1= int.Parse(Console.ReadLine());	  
          Console.WriteLine("So, the number " + base1 + " ^ (to the power) " + exponent1 + " = " + PowerRaising(base1, exponent1));
          Console.ReadKey();
        }
        public static int PowerRaising(int base2, int exponent2)
        {
          int rvalue = 1;
          int i;
          for (i=1;i<=exponent2;i++)
          rvalue=rvalue*base2;
          return rvalue;
        }
    }
}
