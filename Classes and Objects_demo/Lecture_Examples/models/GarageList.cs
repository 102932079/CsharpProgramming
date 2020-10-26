using System.Collections.Generic;

namespace LectureExamples
{
    public class GarageList
    {
        public List<Car> carsList;
        
        public GarageList () {
            this.carsList = new List<Car>();
        }


        public void AddCar(Car newCar) {
            // optional task.  Limit the amount of cars in this garage to 3
            // optional task2.  Limit the amount of cars to a defined number
            this.carsList.Add(newCar);
        }




        

    }
}