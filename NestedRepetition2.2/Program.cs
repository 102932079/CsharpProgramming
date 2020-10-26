using System;

namespace NestedRepetion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number");
            string inputString = Console.ReadLine();
            int input = int.Parse(inputString);

            int counter1 = 0;

            while (counter1 < input)
            {
                for(int counter2 = counter1;counter2<input;counter2++)
                {
                System.Console.Write("X");
                }
                System.Console.WriteLine();

                counter1++;

            }
            Console.ReadKey();
      }
    }
}
