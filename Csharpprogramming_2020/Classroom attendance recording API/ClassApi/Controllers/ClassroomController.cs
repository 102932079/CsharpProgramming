using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClassApi.models;

namespace ClassApi.Controllers
{
    //defalut item
    [ApiController]
    [Route("[controller]")]
    public class ClassroomController : ControllerBase
    {
        //create list array
        //what kind list avaliable to pick or in the system?
        //for get all record(logs list) ative? record everything?
        public static List<Classroom> Logs = new List<Classroom>();
        //for check a room(room list) how to do avaliable room
        public static List<string> RoomsList = new List<string>() {"TD224", "AGSE111","ABC123"};
        //for check a person(name list)
        public static List<string> NameList = new List<string>() {"John Doe","Jane Black", "Foss"};
        // may dont even need room and name list

        //how to insert time here??
        DateTime  DT1 = new DateTime(2020,09,13,09,30,00);
        DateTime  DT2 = new DateTime(2020,09,13,12,30,00);
        public ClassroomController()
        {
            // wrong way of add data
            // new Classroom("TD224", "John Doe");
            // new Classroom("AGSE111", "Jane Black");
            // new Classroom("ABC123", "Foss");
            //cant put time in parameter due to no construtor
            //cant use add in here due to no unque array name
            Logs.Add(new Classroom("TD224", "John Doe"));
            Logs.Add(new Classroom("AGSE111", "Jane Black"));
            Logs.Add(new Classroom("ABC123", "Foss"));
        }
        

        //========================================================================================
        // get all logs (inuse or its a history log )
        // do we delete this log after log out but how about calculater
        [HttpGet("getAllLogs")]
        public List<Classroom> GetAllLogs()
        {
            return Logs;
        }

        //get all rooms (in use)
        [HttpGet("getAllRooms")]
        public List<String> GetAllRooms()
        {
            return RoomsList;
        }

        //get all students (in here)
        [HttpGet("getAllNames")]
        public List<String> GetAllNames()
        {
            return NameList;
        }

        // get a room
        [HttpGet("{roomNo}")]
        //classroom is the returntype getroom method httpget roomno maps variable roomno
        public Classroom GetRoom(string roomNo)
        {
            
            //Find an item in List by LINQ

            Classroom entry = Logs.Find(e => e.RoomNumber.Contains(roomNo));
            return entry;
        }

        // get a person
        [HttpGet("{studentName}")]
        public Classroom GetName(string studentName)
        {
            Classroom entry = Logs.Find(e => e.Name.Contains(studentName));
            return entry;   
        }

        // add new logs (sign in)
        [HttpPost("newEntry")]
        // return type is string  not void
        public string SignIn(Classroom newEntry)
        {
            //String.Contains Method
            //Char.ToUpper Method Converts the value of a Unicode character to its uppercase equivalent.
            // different of return type
            // if (RoomsList.Contains(NewEntry.RoomNumber.ToUpper()))
            // {
            //     NewEntry.RoomNumber.ToUpper();
            // }
            // else
            // {
            //     throw Exception;
            // }
            // try with the method from httppost add neworders
            // cant be classroom number need to be student name due to students can share rooms but student cant attend mutiple classes
            Classroom found = Logs.Find(e =>e.Name == newEntry.Name);

            //check already signed in or not
            if (found == null)
            {
                Logs.Add(newEntry);
                return ("Signed in sucessfully.");
            }
            else
            {
                //how to use here? try catch?
                throw (Exception ex);
                return ex.message;              
                
            }
        }

        // add new logs (sign out) need add new exit to logs delete some of the list? and calculate durtion
        // use name to sign out? or time to sign out?

        [HttpPost("exitRoom")]
        public string SignOut(string exitRoom)
        {
            Classroom vEntry = null;
            // Retrieves a substring from this instance. Substring(Int32, Int32)
            //Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.
            string studentName = exitRoom.Substring(0,3);
            string exitTime = exitRoom.Substring(0, 3);
            // convert string to boolean? string sample = "True";  bool myBool = bool.Parse sample);  bool myBool = Convert.ToBoolean(sample);
            
            bool NameParse = Int32.TryParse(studentName, out int intName);
            bool NameParse = Convert.ToBoolean(studentName, out string )

            if (NameParse)
            {
                foreach (Classroom entry in Logs)
                {
                    if (entry.Name == intName)
                    {
                        vEntry = entry;
                    }
                    else
                    {
                        return "Rejected.Please contact your teacher."
                    }
                }

                vEntry.Exit = vEntry(exitTime);
                vEntry.GetStayedTime();

                // if vEntry.StayedTime < 0? impossiable?
                Logs.Remove(vEntry);
                return "Signed out sucessfully.";
                // all record will desapper?
            }

            else
            {
                return "Invailed Name.";
            }
        }

    

        



    }
}