/*
Bee Keeping
Bee Keeping

A console application needs to created to manage some beehives.  The application needs to be able to:

Create beehives (with bees)
From each beehive run the CollectHoney method for a specified number of days
Report on the number of bees in each beehive
 

To start off create 2 beehives

4 bees (John, Paul, George, Ringo) -> Sizes (3.2, 2.7, 1.1,  2.0)
3 bees (Kurt, Dave, Krist) -> Sizes (2.3, 7.4, 1.5)
Create a class diagram before starting.

Rough parameters below.

Beehive

Bees
Max Amount of Bees
Collect Honey (days: int)
Amount: float = days * bee Size * 0.2
Bee

String: Name
Float: Size
*/

using System;

namespace BeeKeeping
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the bees   
            Bee b1 = new Bee ("John" , 3.2F);
            Bee b2 = new Bee ("Paul" , 2.7F);
            Bee b3 = new Bee ("Ringo" , 1.1F);
            Bee b4 = new Bee ("George" , 2.0F);
            Bee b5 = new Bee ("Kurt" , 2.3F);
            Bee b6 = new Bee ("Dave" , 7.4F);
            Bee b7 = new Bee ("Krist" , 1.5F);

            //instantiate the beehive
            Beehive h1 = new Beehive(4,1);
            Beehive h2 = new Beehive(3,2);

            //add bees to list -Create beehives (with bees)
            h1.AddBee(b1);
            h1.AddBee(b2);
            h1.AddBee(b3);
            h1.AddBee(b4);
            h2.AddBee(b5);
            h2.AddBee(b6);
            h2.AddBee(b7);

            //collect honey calculate-From each beehive run the CollectHoney method for a specified number of days
            h1.CollectHoney(7);
            h2.CollectHoney(8);
            
            //count bee -Report on the number of bees in each beehive
            h1.CountBee();
            h2.CountBee();
            Console.ReadKey();
                  

        }
    }
}
