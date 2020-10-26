using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
           int counter = 0;
           int mod3;
           int mod5;

           while (counter<101)
           {
               mod3 = counter % 3;
               mod5 = counter % 5;

               if (mod5 == 0 && mod5 == 3)
               {
               Console.WriteLine("FizzBuzz");   
               }

               else if (mod3 == 0)
               {
               Console.WriteLine("Fizz"); 
               }

               else if (mod5 == 0)
               {
               Console.WriteLine("Buzz"); 
               }

               else 
               {
               Console.WriteLine(counter);
               }

               counter++;

           }

            Console.ReadKey();
        }
    }
}
