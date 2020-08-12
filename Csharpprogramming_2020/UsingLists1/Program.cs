using System;

namespace UsingLists1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            // read 5 numbers

            int[] numbers = new int[6]; 
 
            // Accepting value from user 

            for (i = 0; i < 5; i++)
            {
                Console.Write("First five numbers");

                //Storing value in an array

                numbers [i] = int.Parse(Console.ReadLine());
            }

            //another number 

            Console.WriteLine("Another nunmber");

            numbers [5] = int.Parse(Console.ReadLine());

            //Printing the value on console

            for (i = 0; i < 6; i++)
            {
                Console.WriteLine(numbers [i]);
            }

            Console.ReadLine();
        }
    }
}
