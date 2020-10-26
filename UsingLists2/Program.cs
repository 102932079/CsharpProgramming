using System;

namespace UsingLists2
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
        int[] arrays = new int [];
        for (int i = 0; i < arrays.Length; i++)
        {
            int input = int.Parse(Console.ReadLine());
            arrays[i] = input;
        }
        */

        int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
        int[] count = new int[13];

        foreach(int number in array) {
        // using the index of count same way you'd use a key in a dictionary
        count[number]++;
        }

        foreach(int c in count) {
        int numberCount = count[c];
        if(numberCount > 0) {
        Console.WriteLine(c + " occurs " + numberCount + " times");
        }  
        }
      
        }
    }
}
