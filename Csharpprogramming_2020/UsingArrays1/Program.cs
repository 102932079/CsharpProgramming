using System;

namespace UsingArrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] names = new string[5];
            names[0] = "Adam";
            names[1] = "Bob";
            names[2] = "Charlie";
            names[3] = "David";
            names[4] = "Eva";

            int index = 0;

            while (index < 5)
            {
                System.Console.WriteLine("Hello" + " " + names[index]);

                index++;
            }
/*
            System.Console.WriteLine("Hello" + names[0]);
            System.Console.WriteLine("Hello" + names[1]);
            System.Console.WriteLine("Hello" + names[2]);
            System.Console.WriteLine("Hello" + names[3]);
            System.Console.WriteLine("Hello" + names[4]);
*/
            Console.ReadKey();
        }
    }
}
