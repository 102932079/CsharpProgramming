using System;

namespace UsingArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};

            int total = 0;

            for (int i = 0; i <number.Length; i++)
            {
                total += number[i];
            }

            Console.WriteLine("The total is" + total);

            Console.ReadKey();
            

        }
    }
}
