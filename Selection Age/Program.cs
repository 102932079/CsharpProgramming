using System;

namespace IntroProgSelection2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            age = 14;
            int legalAge = 18;

            if(age >= legalAge) 
            {
                Console.WriteLine("DRINK");
                Console.WriteLine("DRIVE");
            } 
            else 
            {
                Console.WriteLine("DON'T DRINK");
                Console.WriteLine("DON'T DRIVE WITHOUT THE L-PLATE");
            }

            Console.WriteLine("PROGRAM FINISHED!");
        }
    }
}