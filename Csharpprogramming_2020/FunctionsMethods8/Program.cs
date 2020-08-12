/*
8. Write a program in C# Sharp to create a function to display the n number Fibonacci sequence. 
Test Data : 
Input number of Fibonacci Series : 5 
Expected Output : 
The Fibonacci series of 5 numbers is : 
0 1 1 2 3
*/

using System;

namespace FunctionsMethods8
{
    class Program
    {
      public static int Fibonacci(int nofs)
      {
	    int number1 = 0;
	    int number2 = 1;
	
	    for (int i = 0; i < nofs; i++)
	    {
	      int a = number1;
	      number1 = number2;
	      number2 = a + number2;
	    }
	    return number1;
      }
    
      public static void Main()
      {
	  
	    Console.Write("Input number of Fibonacci Series : ");
        int b = int.Parse(Console.ReadLine());
      
	    Console.WriteLine("The Fibonacci series of "+ b +" numbers is :");	 

	    for (int i = 0; i < b; i++)
	    {
	      Console.Write(Fibonacci(i)+"  ");
	    }  

	    Console.WriteLine();
        Console.ReadKey();

      }
    }
}
