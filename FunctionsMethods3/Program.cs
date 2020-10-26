/*
3. Write a program in C# Sharp to create a function for the sum of two numbers. 
Test Data : 
Enter a number: 15 
Enter another number: 16 
Expected Output : 
The sum of two numbers is : 31
*/
using System;

namespace FunctionsMethods3
{
    class Program
    {
        public static int Sum(int number1, int number2)
        {
        int total;
        total = number1 + number2;
        return total;
        }
     
        public static void Main()
        {
	  
	    Console.Write("Enter a number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter another number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of two numbers is :", Sum(a,b) );
        Console.ReadKey();
        }
    }
}
