/*
2. Write a program in C# Sharp to create a user define function with parameters. 
Test Data : 
Please input a name : John 
Expected Output : 
Welcome friend John ! 
Have a nice day!
*/
using System;

namespace FunctionsMethods2
{
    class Program
    {
            public static void welcome(string name)
            {
             Console.WriteLine("Welcome friend " + name+" !");
            }
            public static void Have()
            {
             Console.WriteLine("Have a nice day!");
            }
            public static void Main(string[] args)
            {
	        string str1;
		    Console.Write("Please input a name : ");
            str1 = Console.ReadLine();	  
            welcome(str1);
            Have();
            }         
    }
    
}
