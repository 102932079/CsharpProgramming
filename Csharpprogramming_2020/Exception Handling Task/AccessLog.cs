using System;
using System.Collections.Generic;


namespace Exception_Handling_Task
{
    public class AccessLog
    {
        
        public string RoomNumber;
        public string Name;
        public DateTime Date;
        public  DateTime Time;        
        public int Duration;

        public AccessLog()
        {
            this.RoomNumber = "";
            this.Name = "";
            this.Date = new DateTime();
            this.Time = new DateTime();
            this.Duration = 0;
        }

       
    }
}