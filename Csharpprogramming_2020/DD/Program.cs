using System;
using System.Collections.Generic;

namespace DD
{
    class Program
    {
        static void Main(string[] args)
        //create variable new is the key word to instantiate 
        {
            Die d1 = new Die();// use a default constrator
            Die d2 = new Die(12);
            Die d3 = new Die(20);

            List<Die> diceList = new List<Die>();
            diceList1.Add(d1);
            diceList2.Add(d2);
            diceList3.Add(d3);

            List<Die> diceList2 = new List<Die>();
            diceList2.Add(d2);

            //create few people
            Person p1 = new Person("William Wallace", diceList1);
            Person p2 = new Person("Joan of Arc", diceList2);

            //p1 is the object .(dot) is the symbol that into that object will show a list of accessable

            System.Console.WriteLine(p1.Name);
            System.Console.WriteLine(p1.Dice.Count);

            System.Console.WriteLine(p2.Name);
            System.Console.WriteLine(p2.Dice.Count);

            p2.AddNewDie(18);
            System.Console.WriteLine(p2.Dice.Count);

            // do sth 20 time with for loop

            for(int i=0; i < 20; i++)
            {
                System.Console.WriteLine(d1.Roll());
                System.Console.WriteLine(d2.Roll());
            }

            for(int i=0; i < 20; i++)
            {
                //roll William Wallace's second die
                System.Console.WriteLine(p1.RollDie(1));
            }
        }
    }
    // the finnal thing to do is check structure before move on

    //the first thing we do is *Create Class* (always public make things accessable)
    public class Die 
    // only create all the class in same file for this demo only 
    // but normally spliting every class in seperate file
    {
        public int NumOfSides;

        // the last thing we do is constructors : It’s a special method that return the object from that class Constructor rule the name of constructor is always the same name of the class include casing (case sensitive) instantiate the object

        public Die(int numofsides)

        // what happen in the parameters is passing in the number of size they want for new die that they going to create
        {
            //set up the object when we created this to that numofsides,take the integer from numofside to what been asked into that interger
            this.NumOfSides = numofsides;
        }

        public Die()
        {
            this.NumOfSides = 6;
        }


        // the second thing we do is *Give Method* Description the method is roll ,we dont know how the roll is work yet but we know the return vales is 0
        public int Roll()
        {
            // random is class from default rand is the new object we create we use new to instantiate
            Random rand = new Random();

            // next is the not negetive random interger and create a variable
            //purpose create a random object and create a random number and we use it to get a random number between 1 and 7 make those into the variable roll then return the roll
        
            int roll = rand.Next(1, (this.NumOfSides + 1));

            return roll; // place holder
        }

        public class Person 
        {    
            public string Name;

                //using function to make list function unlock dice have mutiple die
                public List<Die> Dice;

                //create constrctor

                public Person(string name, List<Die> dice)
                {
                    this.Name = name;
                    this.Dice = dice;
                }

                public Person()
                {
                    this.Name = "John Doe";
                    this.Dice = new List<Die>();
                }

                // The list at the moment is none exist we need to create the list. if die is out of range will return-1
                ///<summary>
                ///Rolls a specified die from the Dice list.
                ///</summary>
                ///<param name="die">indexing strats at 0</param>
                ///<returns></returns>
        


                public int RollDie(int die)

                
                {
                    int roll = -1;
                    if(die > 0 && die < Dice.Count)
                    Dice[die].Roll();
                    return roll; //place holder
                }
                

            ///<summary>
                ///roll all of the player 's dice once and return the total.
                ///</summary>
                ///<param ></param>
                ///<returns></returns>
                public int RollAllDice()
                {
                        return 0;//place holder

                }


                public void AddNewDie(int sides)
                {
                    Die d = new Die(sides);
                    this.Dice.Add(d);
                }       
        }
    }
}
