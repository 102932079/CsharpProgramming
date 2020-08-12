/*
6. Write a program in C# Sharp to create a function to swap the values of two integer numbers. 
Test Data : 
Enter a number: 5 
Enter another number: 6 
Expected Output : 
Now the 1st number is : 6 , and the 2nd number is : 5
*/
using System;

namespace FunctionsMethods6
{
    class Program
    {
        public static void swap(ref int number1, ref int number2)
        {
            int newnumber;
         
            number1 = newnumber;
            number2 = number1;
            newnumber = number2;
    }
        public static void Main()
        {
            int n1,n2;
	  
	        Console.Write("Enter a number: ");
            n1= int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            n2= int.Parse(Console.ReadLine());		
            swap( ref n1, ref n2 );
            Console.WriteLine( "Now the 1st number is : " + n1 + " and the 2nd number is : " + n2);
            Console.ReadKey();
        }
    }
}
