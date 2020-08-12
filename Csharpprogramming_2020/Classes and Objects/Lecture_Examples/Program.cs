using System;
using System.Collections.Generic;

namespace LectureExamples {
    class Program {
        public static void Main(string[] args) {
            
            // instantiation -> create default object from car class
            Car car1 = new Car();
            Car car2 = new Car("ABC123", "Straight 6", 15, "Black", "Sedan", 10);
            Car car3 = new Car("ZXC321", "V6", 4, "Blue", "Van", 20);

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
    }



    



   
}
