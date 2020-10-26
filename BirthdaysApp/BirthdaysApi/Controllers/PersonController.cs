using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BirthdaysLib;
using System.IO;
using System.Globalization;
using CsvHelper;

namespace BirthdaysApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    // only keep the controller base for sample nothing else
    public class PersonController : ControllerBase
    {
        List<Person> people;
        public PersonController()
        {
            // read from the file (csv)
            //this will not work due to the heading text
            // and also we dont know yet if the Dob format in csv work with DateTime
            // need declare List<Person> outside to let Http get also can use it.
            people = new List<Person>();
            //List<Person> people = new List<Person>();
            // dont need to define csvperson outside beacuse we stop using csvpeole in foreeach loop
            List<CsvPerson> csvPeople;
            // libarey not been picked up streamreader/csvreader could not be found
            // we need to import the lib and using up there
            // using system io using golblization using csvhelper
            // some time need to reopen the dir
            using (var reader = new StreamReader("./Birthdays.csv"))
            using (var csv = new CsvReader (reader, CultureInfo.InvariantCulture))
            {    
                var records = csv.GetRecords<CsvPerson>();
                //can not convert
                // soulution old fasion way get string and put all those stuff into foreeach loop and then use the constructor with the string
                csvPeople = records.ToList();

                foreach(CsvPerson cp in csvPeople)
                {
                    people.Add(new Person(cp.FirstName, cp.Surname, cp.Dob));
                }
            }
        }
        // end point - first
        // everyone in the list
        [HttpGet]
        // the system dont know what person is (system error Person could not be found)
        // two things we need to know for make person works
        // 1.references csproj from class lib 2. using in this controller file
        public List<Person> GetAll()
        {
            // return null;
            return people;
        }
        // copy cp birthday csv under birthday api
        // design choice read from file every signle time or does not matter  (funciton layer dont matter) (code layer are different )
        // stitcs list

        [HttpPost]
        public Person AddPerson(CsvPerson cp)
        {
            //how to valid this date 
            //parse and handle the exception if it throws
            DateTime validDate;
            try 
            {
                validDate = DateTime.Parse(cp.Dob);
            }
            catch (Exception)
            {
                // if the date you inpout is wrong return nothing instead clash
                return null;
            }
            
            //might not need to do this?
            //DateTime.TryParse first argument to this method must be of String type, you are passing DateTime object only. Convert x.LogOutTime to String.
            Person newPerson = new Person(cp.FirstName, cp.Surname, cp.Dob); 

            // which object should we use person or csvperson csv will be more eailer (we can use person)
            List<CsvPerson> newRecords = new List<CsvPerson>();
            
            newRecords.Add(cp);

            // error CS1503: Argument 1: cannot convert from 'System.DateTime' to 'string'  can not open the csv file
            // refercing the wrong file
            // serch on google file is th ename of one of the conttrollers methods i fyou want reference th efile class form system io namespace you  need to fully qualify the name 
            using (var stream = System.IO.File.Open("./Birthdays.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                // Don't write the header again.
                csv.Configuration.HasHeaderRecord = false;
                csv.WriteRecords(newRecords);
            }
            
            return newPerson;
        }

        
    }
}
