using System;
using System.Collections.Generic;

namespace BeeKeeping
{
    public class Beehive
    {
        // attributes
        
        public int MaxBee;
        public int BeehiveNumber;
        public List<Bee> BeeList;

        // default constructor

        public Beehive()
        {
            this.BeeList = new List<Bee>();
            this.MaxBee = 0;
            this.BeehiveNumber = 0;
        }

        // variable constructor

        public Beehive(int maxBee, int beehiveNumber)
        {
            this.MaxBee = maxBee;
            this.BeehiveNumber = beehiveNumber;
            this.BeeList = new List<Bee>();

        }

        // methods

        // add bee function

        public void AddBee(Bee newBee)
        {
            this.BeeList.Add(newBee);
        }

        // count bee function

        public void CountBee()
        {
            int counter = 0;
            for (int i = 0; i < this.BeeList.Count; i++)
            {
                counter++;
            }

            System.Console.WriteLine($"{counter}bees in Beehive {this.BeehiveNumber}");
        }

        // collect honey function 

        public void CollectHoney(int days)
        {
            float Amount = 0.0F;
            
            // sumup the bee size in list

            foreach (var Bee in BeeList)
            {
                Amount += days * Bee.BeeSize*0.2F;
            }

            System.Console.WriteLine($"{Amount} honey in {this.BeehiveNumber}");
        }





    }
}