/*
1. Write a program in C# Sharp to create a user define function. 
Expected Output : 
Welcome Friends! 
Have a nice day!
*/
using System;


namespace FunctionsMethods1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Welcome();
            Have();
           Console.ReadKey();
        }

        public static void Welcome()
        {
            System.Console.WriteLine("Welcome Friends! ");
        }

        public static void Have()
        {
            System.Console.WriteLine("Have a nice day! ");
        }
    }
}
