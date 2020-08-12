using System;
using System.Collections.Generic;

namespace LectureExamples {

    class Program {

        public static void Main(string[] args) {

            int wheels = 0;

            System.Console.WriteLine("Enter number of wheels");

            string input = Console.ReadLine();

            try 
            {

            wheels = int.Parse(input);

            if(wheels <1 )
            {
                throw new Exception();
            }

            throw new NullReferenceException();
            // finnal null format

            } 
            catch (FormatException ex)
            // more like else if ex.stacktrack useful for developer
            {
                System.Console.WriteLine($"Input can't be converted to a integer :( - Closing Program - {ex.Message}");
                //system.Environment.Exit(1);
            }
            catch (NullReferenceException ex)
            {
                System.Console.WriteLine($"Object doesn't exist :( - Closing Program - {ex.Message}");
                //system.Environment.Exit(1);
            }
            catch (Exception ex) 
            {
                System.Console.WriteLine($"Something went wrong :( - Closing Program - {ex.Message}");
                //system.Environment.Exit(1);
                //return; above code is simple way to do 1 is only do once not in the loop the program will stop from here when try and catch something
            }
            finally 
            {
                //finnally will always run good for reset
                //MainMenu();
                System.Console.WriteLine($"!!!Finally block!!!");
            }

            Car car4 = new Car("ARS123", "V8", wheels, "White", "Ute", 5);
            /*
            try
            {
                //try /attempt to run some code
                
            } 
            catch ()
            {
                // catch the relevant exception and run some code
            }
            */
            

            
            
            







            // instantiation -> create default object from car class
            Car car1 = new Car();
            Car car2 = new Car("ABC123", "Straight 6", 15, "Black", "Sedan", 10);
            Car car3 = new Car("ZXC321", "V6", 4, "Blue", "Van", 20);
            Car car4 = new Car("ARS123", "V8", wheels, "White", "Ute", 5);


            Garage g1 = new Garage();
            g1.AddCar(car1);
            g1.AddCar(car3);
            g1.AddCar(car3);

            GarageList g2 = new GarageList();

            // change speed of car2 to 30
            car2.SetNewSpeed(30);

            // car2 to honk at car3
            car2.HonkAtBadDrivers("What the Fuck!  Matt get off the road!", car3);

            Console.ReadKey();


        }
        /*
        public void blahMethod()
        {
            int x = 0;

            return;

            System.Console.WriteLine(x);

        }
        */
    }



    



   
}
