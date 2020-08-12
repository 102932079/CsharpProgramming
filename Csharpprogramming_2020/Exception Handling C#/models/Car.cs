namespace LectureExamples
{
    public class Car
    {
        // attributes / variables
        public string Rego;
        public string Motor;
        public int AmountOfWheels;
        public string Colour;
        public string BodyType;
        public int CurrentSpeedKmh;


        // constructors
        public Car () {
            this.Rego = "";
            this.Motor = "";
            this.AmountOfWheels = 0;
            this.Colour = "White";
            this.BodyType = "";
            this.CurrentSpeedKmh = 0;
        }

        public Car (string rego, string motor, int amountOfWheels, string colour, string bodyType, int currentSpeedKmh) {
            this.Rego = rego;
            this.Motor = motor;
            this.AmountOfWheels = amountOfWheels;
            this.Colour = colour;
            this.BodyType = bodyType;
            this.CurrentSpeedKmh = currentSpeedKmh;
        }

        // methods / functions / operations
        public void Honk () {
            System.Console.WriteLine("Honk");
        }

        public void HonkAtBadDrivers (string choiceWords, Car car) {
            System.Console.WriteLine("HONK HONK " + choiceWords + " at " + car.GetRego());
        }

        public void SetNewSpeed (int newSpeed) {
            this.CurrentSpeedKmh = newSpeed;
        }

        public string GetRego () {
            return this.Rego;
        }

        public string GetOtherRego (Car car) {
            return car.GetRego();
        }

    }
}