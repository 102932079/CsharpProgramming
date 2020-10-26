// Welcome Back: Task 2
// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
// Write a program that will return the smallest positive number that can be divided by each number from 1 to a user given number.
// Adapted from:  https://projecteuler.net/problem=5
// solution https://www.youtube.com/watch?v=WjUdCdfJSMs&list=PLBCSL4JHGB2dJH0uAnHulGcxbVx3CkN9p&index=53&t=1128s

using System;
using System.Collections.Generic;
using System.Linq;

namespace models
{
    public class Divided
    {
        // user given number max
        publicint remainderCheck(int max)
        {
            // candidtate numbers can be stroed here
            List<int> CanBedividedByAll = new List<int>();

            int counter = 1;
            int mainInt = 3000;
            
            for (int i = 1; i <= max; i++ )
            {
                //check if there is remainder
                var noRemainder = mainInt % i;

                if (noRemainder == 0)
                {
                    counter++;

                    // collecting the no remainer and save it in the array

                    if(counter == max)
                    {
                        CanBedividedByAll.Add(mainInt);
                    }
                }
                else
                {
                    mainInt--;
                    i = 1;
                    counter = 1;
                }
            }

            // pick out the min

            int outputMin = CanBedividedByAll.Min();
            // not console dont use writeline
            return outputMin;

    
        }
    }
}
