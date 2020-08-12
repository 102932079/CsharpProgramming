namespace LectureExamples
{
    public class Garage
    {
        Car car1;
        Car car2;
        Car car3;

        public void AddCar(Car newCar) {
            if (car1 == null) {
                car1 = newCar;
            }  else if (car2 == null) {
                car2 = newCar;
            } else {
                car3 = newCar;
            }
        }
    }
}