using System;

//A variable is nothing but a name given to a storage area that our programs can manipulate. Each variable in C# has a specific type, which determines the size and layout of the variable's memory the range of values that can be stored within that memory and the set of operations that can be applied to the variable.
// object can contain another object c1.en1.NumCylinders
namespace Class_Object_Car
{
    // between curly braces (bracket) called program box (the class should be always start with capital)
    //after the construtors and method we now can start to create the car(instantiate)
    class Program
    {
        static void Main(string[] args)
        {
            Engine e1 = new Engine(4, 500);
            
            Car c2 = new Car ("ZXC987", 8, 0, 0, e1);
            
            Car c3 = new Car ("ABC123", 5, 0, 0, 6, 300);

            System.Console.WriteLine(c3.en.NumCylinders);
            System.Console.WriteLine(c2.en.NumCylinders);


            // instantiate a new car - look at variable declear the type and give it values
            //type is car new keyword does the instantiating (create a new defalut car )
            //after keyword new we call the construtor (construoter define values)
            Car c1 = new Car();
            // it will broken when insert engine with car beacuse no construtors renference
            //Car c2 = new Car( "ABC123", 5 , 0, 0, 0);

            Car c2 = new Car( "ABC123", 5 , 0, 0, 0, 6, 300);

            //use c2 to locate the car object then use . to goes to the next level(attribute and method) into the box next layout
            // int dot menu attribute blue messageer purple

            System.Console.WriteLine($"Before:" + c2.Passengers);

            c2.UpdatePassengers(5);

            System.Console.WriteLine($"after:" + c2.Passengers);

            System.Console.WriteLine(c1.Passengers);

            c2.UpdatePassengers(-3);

            System.Console.WriteLine($"after:" + c2.Passengers);

            c2.UpdatePassengers(-6);

            System.Console.WriteLine($"after:" + c2.Passengers);

            
        }
    }

    //----------------------------------------------------------------------------------------------
   

    // object can contain another object c1.en1.NumCylinders
    //defalut string will be null or blank defarlut int will be 0
     class Engine
     {
         //attribute
         public int NumCylinders;
         public int CylinderSize;

         //create defalut constutor and input construtor
         //also we can use the light bulb next to class to generate constutor automatily with vscode system


         public Engine ()
         {
             this.NumCylinders = 0;
             this.CylinderSize = 0;
             
         }
         public Engine (int nc, int cs)
         {
             this.NumCylinders = nc;
             this.CylinderSize = cs;

         }


         public void Rev()
         {
             System.Console.WriteLine("Vroom Vroom");
         }

     }




    //-----------------------------------------------------------------------------------------------


    public class Car
    // do first define attributes what you what those thing do in the system - modelling what car can do
    //the references below is from construtors

    // when we create a class just put public for every class attrribute method you created for accessbility
    {
        public string Rego;
        public int PassengerLimit;
        public int Passengers;
        public int Xcord;
        public int Ycord;

        //make other object into an attribute engine to car
        public Engine en;

        //=============================================================================================================
        //do third add constructors -part of class allow it to create object (will be always public beacuse it will be called by external code)
        //the name of constructors will be the always the class case sensitive
        //defalut constructors beacuse of there is nothing in parmeter list
        //in the constrctor we initiate the defalut as well (determine what are those values are)
        //those initiate below are referencing the attribute above
        //this key word mean the attributre from this(car) class
        //beacuse i can create int Rego ; Rego = 10; but it's different from this.rego
        
        public Car()
        {
            this.Rego = "";
            this.PassengerLimit = 0;
            this.Passengers = 0;
            this.Xcord = 0;
            this.Ycord = 0;
            this.en = null;
        }

        //it could has mutiple construtors, provide more parameter with values and provide information to the method
        //the construtor above is for set up defalut the constutor below is for ask the values pass into the each of attribute
        /*
        public Car(string rego, int pl , int pass, int x, int y, Engine e)
        {
            this.Rego = rego;
            this.PassengerLimit = pl;
            this.Passengers = pass;
            this.Xcord = x;
            this.Ycord = y;
            this.en = e;

        }
        */
        //threre are two way of insert engine to car as a whole or all the attribe from engine
        public Car(string rego, int pl , int pass, int x, int y, int nc, int cs)
        {
            this.Rego = rego;
            this.PassengerLimit = pl;
            this.Passengers = pass;
            this.Xcord = x;
            this.Ycord = y;
            this.en = new Engine(nc, cs);

        }



        //===============================================================================================================

        // do senond oprations method the return type is the object itself

        ///<summary>
        ///Adds number of newPassengers to passengers. to remove passengers provide negatove newPassengers values
        ///</summary>
        ///<param name="newPassengers"></param>
        // those oprators
        //c += a ---- c = c + a
    
        public void UpdatePassengers(int newPassengers)
        {
            // check to not exeed the passenger limit and reasonable
            /*
            if ( this.Passengers + newPassengers >= 0 )
            {
                if ( this.Passengers + newPassengers <= this.PassengerLimit )
                {
                this.Passengers += newPassengers;
                }
            }
            */
            // && and ||or
            if (this.Passengers + newPassengers <= this.PassengerLimit && this.Passengers + newPassengers >= 0 )
            {
                this.Passengers += newPassengers;
            }
            
            
            
        }

        public void Move(int newX, int newY)
        {
            this.Xcord = newX;
            this.Ycord = newY;

        }

        


    }
}
