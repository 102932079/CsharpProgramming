using System;
using System.Collections.Generic;


namespace Exception_Handling_Task
{
    class Program
    {
        static void Main(string[] args)
        {        
            var record1 = new Class();
            var record2 = new Class("TD224", "John Doe", 12 );
            var record3 = new Class("AGSE111", "Jane Black", 15 );     
         

            DateTime  DT2 = new DateTime(2020,08,03,14,30,00);
            DateTime  DT3 = new DateTime(2020,02,23,08,20,00);
            

            record2.EntryDateTime = DT2;
            record3.EntryDateTime = DT3;

            //FormatException
            try
            {
            var record4 = new Class();
            DateTime  DT4 = new DateTime(9999,99,99,99,99,99);
            record4.EntryDateTime = DT4;
            System.Console.WriteLine(record4.EntryDateTime);
            }
            catch(FormatException ex1)
            {
                System.Console.WriteLine($"Input can't be converted to an integer :( Closing Program - {ex1.Message}");
            }
            catch (Exception ex2)
            {
                System.Console.WriteLine($"Something went wrong :( Closing Program - {ex2.Message}");
            }
            finally
            {
                System.Console.WriteLine("!!!Finally block!!!");
            }

            //NullReferenceException 
            try
            {            
            var record5 = new Record();
            var log = new Record();
            record5.Logs.Add(log);
            }
            catch(NullReferenceException ex3)
            {
                System.Console.WriteLine($"Object doesn't exist :( Closing Program - {ex3.Message}");
            }
            catch(Exception ex4)
            {
                System.Console.WriteLine($"Something went wrong :( Closing Program - {ex4.Message}");
            }
            finally
            {
                System.Console.WriteLine("!!!Finally block!!!");
            }



            
        }
    }

    public class Class
    
    {
        public string RoomNumber;
        public string Name;
        public DateTime EntryDateTime;   

        public int Duration;
        
        

        public Class()
        {
             

        }
        
        public Class(string roomNumber, string name, int duration)
        {
            this.RoomNumber = roomNumber;
            this.Name = name;                        
            this.Duration = duration;
            this.EntryDateTime = new DateTime();
            
        }
    }

    public class Record
    {
        public List<Record> Logs;

        public Record()
        {
            //remove below for NullReferenceException  
            //Logs = new List<Record>();
        }

    }



   

    
    
        
           
        
    
}
