using System;

namespace NestedRepetition3
{
    class Program
    {
        static void Main(string[] args)
        {
            int offset = 0;

            for(int i = 1; i<7; i++)
            {
                for(int j = 0; j<offset; j++)
                {
                    Console.Write(" ");
                }

                for(int j = 1;j<(12 - 2 * offset); j++)
                {
                    Console.Write("X");
                }

                for(int j = 0; j<offset; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
                offset++;
            }
            
            Console.ReadKey();
        }
    }
}
