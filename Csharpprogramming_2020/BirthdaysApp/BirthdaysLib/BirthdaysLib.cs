using System;
// later add some stuff for Api

namespace BirthdaysLib
{
    public class Person
    {
      
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime Dob { get; set; }

        public Person()
        {
        }

        // cant find this beacuse the read from csv are different
        public Person(string firstName, string surname, DateTime dob)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            
            //error CS1503: Argument 1: cannot convert from 'System.DateTime' to 'long'
            //this.Dob = new DateTime(dob);
            // C# datetime convert from string 
            //BirthdaysLib.cs(25,39): error CS1503: Argument 1:
            this.Dob = DateTime.Parse(dob);
            //reload command line -re
        }

        public string GetFullName()
        {
            return $"{FirstName}{Surname}";
        }
        public int GetAge()
        {
            return (DateTime.Now - Dob).Days / 365;
        }
    }
    // create another class for string beacuse everything  from the csv file is a string
    // class refelxton
    public class CsvPerson
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Dob { get; set; }
    }
}
