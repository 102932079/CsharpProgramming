namespace LectureExamples
{
    public class Car
    {
        //Attributes / Variables
        public string Rego;
        public string Motor;
        public int AmountOfWheels;
        public string Colour;
        public string BodyType;
        public int CurrentSpeedKmh;

        //Constructors
        public Car () 
        {
            this.Rego = "";
            this.Moter = "";
            this.AmountOfWheels = 0;
            this.Colour = "White";
            this.BodyType = "";
            this.CurrentSpeedKmh = 0;
        }

        public Car (string rego, string motor, int AmountOfWheels, string Colour, string BodyType, int CurrentSpeedKmh)
        {
            this.Rego = rego;
            this.Motor = motor;
            this.AmountOfWheels = amountOfWheels;
            this.Colour = colour;
            this.BodyType = bodyType;
            this.CurrentSpeedKmh = currentSpeedKmh;
        }

        // Methods / Funcitons / Operations
        public void Honk ()
        {
            System.Console.WriteLine("Honk");
        }

        public void HonkAtBadDrivers (string choceWords, Car car)
        {
            System.Console.WriteLine( " HONK HONK " + choceWords + " at " + car.GetRego());
        }

        public void SetNewSpeed (int newSpeed)
        {
            this.CurrentSpeedKmh = newSpeed;
        }
        
        public string GetRego ()
        {
            return this.Rego;
        }

        public string GetOtherRego (Car car)
        {
            return car.GetRego();
        }
    }
}