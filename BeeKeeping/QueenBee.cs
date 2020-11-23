// Add a Queen Bee
// Inherits from Bee
// Default size of 0 
// MakeBee(name: string)
// All bees born from Queen Bee are of size 0.1f
// Allow a user to access a hive with a Queen Bee to create more bees.

using system;
using Bee;

namespace BEEKEEPING 
{
    public class QueenBee : Bee
    {
        public  QueenBee(string name, float size) : base(name, size)
        {
            this.beeSize = 0; //queen is size of 0
        }

        public Bee MakeBee(string name){
            Bee newBee = new Bee();
            newBee.beeSize = 0.1f;
            newBee.Name = name;
            return newBee;
        }
    }

}