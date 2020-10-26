//pretty terminals
// csv helper is a libeary
//dotnet add package CsvHelper 
//csv helper package will into the obj file
//ls list files
// cp copy
// open(open folder) code(reopenprogram with this folder)
//csv helper website
using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
//array
using System.Linq;
//tolist

namespace CsvHelperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Birthday> recordsList;
            // should be always in main 
            //using csv helper (streamreader)
            //using system io (csvreader)
            //using system golblelizaiton (cultureinfo)
            // why io -- exception Unhandled exception. System.IO.IOException: (the csv file is been using)
            //can not cp csv due to overwrite itself
            // we also can write
            //Header not found (header name not correct)
            using (var reader = new StreamReader("./Birthdays.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {    //foo - birthday
                var records = csv.GetRecords<Birthday>();
                //c# ienumable to list
                // list system collections generic 
                //to list using linq
                recordsList = records.ToList();
                // List<Birthday> recordsList = records.ToList();
                // System.Console.WriteLine(recordsList.Count);
            }
            // works
            // foreach(Birthday b in recordsList)
            // {
            //     System.Console.WriteLine($"{b.First_Name}{b.Last_Name}{b.BOD}");
            // }

            List<Birthday> newRecords = new List<Birthday>
            {
                new Birthday() {First_Name = "Adam", Last_Name = "West", BOD = "26/11/1901"},
                new Birthday() {First_Name = "Roger", Last_Name = "Bob", BOD = "02/08/1910"}
            };
            
            // // Write to a file. - this will overwriting everyting
            // using (var writer = new StreamWriter("./Birthdays.csv"))
            // using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            // {    
            //     csv.WriteRecords(newRecords);
            // }

            //appending to an existing csv file
            //append to the file (few extra steps of file opening) add from bottom
            using (var stream = File.Open("./Birthdays.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                // Don't write the header again.
                csv.Configuration.HasHeaderRecord = false;
                csv.WriteRecords(newRecords);
            }
            // csv will be a little bit different with database (not very effieentcy as DB)


        }
    }

    public class Birthday
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string BOD { get; set; }

    }
}
