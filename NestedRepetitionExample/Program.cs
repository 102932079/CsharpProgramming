using System;

namespace nestedrepetition
{
    class Program
    {
        static void Main(string[] args)
        {
  /*
            This is what we are aiming at:
            
            xxxxx
            x   x
            x   x
            x   x
            xxxxx
*/

            Console.WriteLine("Please enter the number of rows and columns you want in the square");
            string inputString = Console.ReadLine();
            int input = int.Parse(inputString);

            for (int row = 1; row<=input; row++)
            {
                for (int column = 1; column<=input; column++)
                {
                    if (row == 1 || row == input || column == 1 || column == input){
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}