using System;

namespace NestedRepetion
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter1 = 0;

            while (counter1 <5)
            {
                for(int counter2 = counter1;counter2<5;counter2++)
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
