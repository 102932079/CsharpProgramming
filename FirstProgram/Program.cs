using System;

namespace FirstProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your firstname?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What's your surname?");
            string surname = Console.ReadLine();

            string fullname = firstname + " " + surname;

            Console.Write(fullname);
        }
    }
}