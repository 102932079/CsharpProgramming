/*
5. Write a program in C# Sharp to calculate the sum of elements in an array. 
Test Data : 
Input 5 elements in the array : 
element - 0 : 5 
element - 1 : 7 
element - 2 : 3 
element - 3 : 2 
element - 4 : 9 
Expected Output : 
The sum of the elements of the array is 26
*/

using System;

namespace FunctionsMethods5
{
    class Program
    {
        public static void Main() 
        {
         int[] Array = new int[5];

         int i, total=0;
	
	     Console.Write("Input 5 elements in the array : ");

	     for(i=0;i<5;i++)
         {
	      Console.Write("element - {0} : ",i);

		  Array [i] = int.Parse(Console.ReadLine()); 
	     }

         for(i=0; i<5; i++)
         {
          total += Array [i];
         }

         Console.Write("The sum of the elements of the array is  ", total);

         Console.ReadKey();
        }
    }
}
