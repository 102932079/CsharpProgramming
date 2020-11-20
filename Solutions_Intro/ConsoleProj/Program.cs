using System;
using PersonLib;

namespace ConsoleProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            System.Console.WriteLine("Enter Name");
            string input = Console.ReadLine();
            p.Name = input;

            System.Console.WriteLine("Enter Year of Birth");
            input = Console.ReadLine();
            p.YearOfBirth = int.Parse(input);

            System.Console.WriteLine($"Hi {p.Name} you are {p.CalcAge()} years old");
        }
    }
}
