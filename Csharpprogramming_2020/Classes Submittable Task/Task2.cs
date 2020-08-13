using System;
using System.Collections.Generic;  
using System.Linq;
using System.Text; 

namespace Classes_Submittable_Task
{
    static void Main(string[] args)
    {
        //instantiating 3 new people
        Person p1 = new Person("A", "D", 170, new DateTime(1980,01,01));
        Person p2 = new Person("B", "E", 180, new DateTime(1990,01,01));
        Person p3 = new Person("C", "F", 190, new DateTime(2000,01,01));
        
        //print 2 method fullname + height different
        Console.WriteLine(p1.PrintFullName() + " has " + p1.ShowHeightDifference(p2) + " cm difference to " + p2.PrintFullName() );

        Console.WriteLine(p2.PrintFullName() + " has " + p2.ShowHeightDifference(p3) + " cm difference to " + p3.PrintFullName() );

        Console.WriteLine(p3.PrintFullName() + " has " + p3.ShowHeightDifference(p1) + " cm difference to " + p1.PrintFullName());

        //add new subjects to a person
        p1.AddListSubjects("Csharp", 2020);
        p2.AddListSubjects("Web", 2020);
        p3.AddListSubjects("Database", 2020);
            

            
        Console.WriteLine("list of subjects");
        Console.WriteLine(p1.PrintFullName() + " studies ");
        Console.WriteLine(p1.PrintSubjectList());
        Console.WriteLine(p2.PrintFullName() + " studies "); 
        Console.WriteLine(p2.PrintSubjectList());
        Console.WriteLine(p3.PrintFullName() + " studies ");
        Console.WriteLine(p3.PrintSubjectList());

            
        Console.WriteLine("ID");
        Console.WriteLine(p1.PrintFullName() + "'s " + " ID is " + p1.ID);
        Console.WriteLine(p2.PrintFullName() + "'s " + " ID is " + p2.ID);
        Console.WriteLine(p3.PrintFullName() + "'s " + " ID is " + p3.ID);


        
    } 

    public class Person
    {
        //attributees
        public string FirstName;
        public string Surname;
        public int Height;
        public DateTime DOB;
        public int ID;     
        public List<Subject> PerSub;

        // constructor

        public Person()
        {
        }

        public Person(string f, string s, int h, DateTime d)
        {
            this.FirstName = f;
            this.Surname = s;
            this.Height = h;
            this.DOB = d;

            // create a empty list
            this.PerSub = new List<Subject>();

            //create an instance of random object
            var ran = new Random();

            //store random number in object.next(n,n)

            int ranID = ran.Next(1000,9999);

            //return values into person id

            this.ID = ranID;

            // because this is inside the constructor, everytime an instance of a person is created a random Id will be created in this.ID

        }

        //method build print fullname function

        public string PrintFullName()
        {
            return this.FirstName + "." + this.Surname;
        }

        //method build show person height differentce function

        public int ShowHeightDifference(Person p)
        {
            return this.Height - p.Height;
        }

        // method - string builder method--- comes with the convert to string method at the end - ideally made for building a string from a loop

        public string PrintSubjectList()
        {
            StringBuilder builder = new StringBuilder();
            //string somestring = "";
            foreach (Subject subject in this.PerSub)
            {
                builder.Append(subject.name + "");
                builder.Append(subject.YearOfDelivery + "");

                //somestring += subject.name +"";
                //somestring += subject.Yearofdelivery + "";
                //or
                //string interpolation///
                //someString += $"{subjects.name} {subjects.YearofDelivery}\n";
            }
            return builder.ToString();
            
        }

        //this function creates a new instance of a Subject and adds it to the list of subjects associated with the person it's called on.

        public void AddListSubjects(string subName, int subYear)
        {
            //create the new instance of a subject using the constructor from Subject (arguments from the function above)
            var AddListSubjects = new Subject(subName, subYear);
            //theperson it's called on. the list name in attributes.the add method(the variable where th info is stored)
            this.PerSub.Add(AddListSubjects);

        }



    }

    public class Subject
    {
        public string name;
        public int YearOfDelivery;

        /// constructor 

        public Subject(string name, int yearOfDelivery)
        {
            this.name = name;
            this.YearOfDelivery = yearOfDelivery;
        }
    }    
}