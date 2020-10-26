using System;
using System.Collections.Generic;
namespace UsingLists3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<string> words = new ArrayList<string>();

            for (int i = 0; i < words.Length; i++)
            {
              string input = Console.ReadLine();

              ArraysList[i] = input;
            }
            

            while (Console.ReadKey("stop"))
            {
                words.Reverse();
                foreach (string word in words)
                Console.WriteLine(word);
            }

            Console.ReadKey();


            

        }
    }
}
