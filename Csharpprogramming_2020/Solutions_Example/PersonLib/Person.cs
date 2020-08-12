using System;
using CarLib;

namespace PersonLib
{
    public class Person
    {
        public string Name;
        public int YearOFBirth;
        public Car MyCar;

        public int CalcAge()
        {
            if(this.YearOFBirth < 1900 )
            {
                throw new Exception("You're too old to be alive. Unless you are James Hallinan");
            }
                
            return DateTime.Now.Year - YearOFBirth;
        }

        

    }
}
