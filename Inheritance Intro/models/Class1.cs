using System;

        // +Inheritance is the concept of reuse and generalization ( when you do not want to copy the attribute and method twice)
        // children class partent class , attribute of student , attribute of person , a child only can have one partent , in c++ you have more
        // +in c# private variable send down (controller base is inheritance) , dog inheritance from animals connect with : (means inheritance)
        // +virtual method can override when in inheritance (mush use virtual for override later)
        // +they use same sort of method but in details they works differently
        // +call partent method call through base
        // `abstract class you you can not instantiate

        //!this will be quite usefull you can create you own exception class from inheritance class

namespace Inheritance_Intro
{
    public class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // ctor
        public Person() {}

        public Person(string name, string phoneNumber, string email) {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void PurchaseParkingPass() {
            throw NotImplementedException;
        }
    }

    public class Student : Person {// child classes attribute

        public int StudentNumber { get; set; }
        public int AverageMark { get; set; }

        // !parent constructor requires plus its own and then we are going to directly pass up what the parents needs calling the base constructor
        // `just like calls a method 

        // `after : is a call before : is the decoration of the signature
        public Student(string name, string phoneNumber, string email, int StudentNumber, int AverageMark) : base(name, phoneNumber, email)
        {   //+base(name, phoneNumber, email); some other language call here like python
            //if we not doing this way otherwise we are demend to use lots of this keyword in inheritance (instansiate)
            this.StudentNumber = studentNumber;
            this.AverageMark = averageMark;
        }

        // `a better way of express look up
        // public Student(string name, string phoneNumber, string email) : base(name, phoneNumber, email)
        // {

        // }

        // public Student(int StudentNumber, int AverageMark)
        // {
        //     this.StudentNumber = studentNumber;
        //     this.AverageMark = averageMark;
        // }

        public bool IsEligibleToEnroll() {
            return  false;
        }

        public void GetSeminarsTaken() {

        }
    }

    public class MattStudent : Student { // this will have an error which missing ctor

        public MattStudent(string name, string email, string phoneNumber, int studentNumber, int averageMark) : base(name, email, phoneNumber, studentNumber, averageMark)
        {
            // `it's call student as parent (base) and part of that sent to parent keeping cascade up and down
            this.AverageMark = 1;
        }
        // `not perfer grandparent because the inheritance will become too deep, will be hard to control
        public bool WillPass() {
            return false;
        }
    }
    {
        
    }
}
