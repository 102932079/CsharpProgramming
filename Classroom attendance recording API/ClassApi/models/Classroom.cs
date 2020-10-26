using System;



namespace ClassApi
{
    public class Classroom
    {
        //A
        public string RoomNumber { get; set; }
        public string Name { get; set; }
        public DateTime Entry { get; set; }
        public DateTime Exit { get; set; }

        //doubel or int? need to be double due to math round
        public double Duration { get; set; }

        //C
        // or i should put entry time here 
        public Classroom(string roomNumber, string name)
        {
            this.RoomNumber = roomNumber;
            this.Name = name;

            //this.Entry = ConvertTimes(entry);
            // how to became a variable?
            this.Entry = new DateTime();
            this.Exit = new DateTime();
            this.Duration = this.GetStayedTime();
        }

        //M
        public double GetStayedTime()
        {
            //Standard TimeSpan format strings
            TimeSpan stayInMinutes = this.Exit - this.Entry;
            //Round(Double, Int32) Rounds a double-precision floating-point value to a specified number of fractional digits, and rounds midpoint values to the nearest even number.
            //TimeSpan.TotalMinutes Property
            Double roundedStayedTime = Math.Round(stayInMinutes.TotalMinutes, 0);
            return this.Duration = roundedStayedTime;
            

        }

        //seems no need

        // public DateTime ConvertTimes(string input)
        // // convert a string to a number int	ToInt32(String)  double	ToDouble(String)
        // {
        //     DateTime convertedInput = new DateTime();

        //     try
        //     {
        //         convertedInput = DateTime.Parse(input);
        //     }
        //     catch(Exception)
        //     {
        //         System.Environment.Exit(1);
        //     }

        //     return convertedInput;

        // }

        


    }
}
