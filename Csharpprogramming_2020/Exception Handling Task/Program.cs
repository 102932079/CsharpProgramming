using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Exception_Handling_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AccessLog> RoomList = new List<AccessLog>();
            AccessLog student = new AccessLog();

            string roomInput = "";

            try
            {
                System.Console.WriteLine("Enter RoomNumber:");
                roomInput = Console.ReadLine();
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            
                
            
        }
    }
}
