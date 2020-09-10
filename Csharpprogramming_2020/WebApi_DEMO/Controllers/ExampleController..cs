// when we create a controllers is class based 
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    // we need to tell system where to find controller
  
    [Route("[controller]")]
    // : inherite pass on (the class example inherite from controllerbase is takes everything from controllerbase)
    // what is controllerbase we dont know but its sth that api needs it to make control works
    
    // in postman use local url then example (controller name)
    //test id and invalid id with post man
    public class ExampleController : ControllerBase
    {
        //stateless for static means
        // static load the variable list outside the 
        static public List<Person> People = new List<Person>();
        // keep track of how many time the static been hit
        static public int StaticCountInstances = 0;
        public int CountInstance  = 0;
        //constructor been hit three time 
        //when the constrauctoer been called 
        public ExampleController()
        {
            // full course is get yourself be eiffient
            // People = new List<Person>();
            // People.Add(new Person("Jason", "007", 77));
            // People.Add(new Person("James", "008", 77));
            // People.Add(new Person("Maxwell", "86", 60));
            // People.Add(new Person("Unknown", "99", 50));
            // this keyword is this object don't work on static
            StaticCountInstances++;
            this.CountInstance++;
        }
        //old content from 24 AUG
        // //http get from forms GET POST PUT HEAD DELETE PATCH OPTIONS (form request)
        // [HttpGet]

        // public string Get()
        // {
        //     return "Hello";
        // }

        // // the http get will recive a message and message url will be "hello"

        // [HttpGet("{message}/{name}")]
        // // can pass in values in url 

        // public string Get(string message, string name)
        // {
        //     return message + " " + name;
        //     //print that message(parameter)
        // }

        // [HttpGet("{name}")]

        // public string Get(string name)
        // {
        //     return name;
        //     //print that message(parameter)
        // }

        // // start a new webapi project: 
        // [HttpPost]
        // //[where to find this element]
        // public string Post([FromBody] Person p)
        // {
        //     Person found = null;
        //     foreach (var pp in People)
        //     {
        //         if (p.ID == pp.ID)
        //         {
        //             found = pp;
        //             break;
        //         }
        //     }

        //     if (found != null )
        //     {
        //         return found.Name + " " + found.ID;
        //     }
        //     else
        //     {
        //         return "Not Found";

        //     }

        //new content from 31 AUG
        //this making end point
        [HttpGet("GetAll")]
        
        public List<Person> GetAll()
        {   
            return People;

        }

        [HttpGet("GetRequests")]
        public int GetRequestAmount()
        {
            return StaticCountInstances;
        }

        //create another end point
        //routing
        [HttpGet("{id}")]
        // return whole json object
        public Person GetPerson(string id)
        {
            Person found = null;
            //predicate another way to replace foreach
            //found =Prople.Find(p +> p.Id == id); javascript
            foreach (Person p in People)
            {
                if (p.Id == id)
                {
                    found = p;
                    break;
                }

            }
            //convertted to LINQ
            // foreach (var p in from Person p in People
            //                     where p.Id == id
            //                     select p)
            // {
            //         found = p;
            //         break;
                                    
            // }
            return found;
            //linq allow lots of function for csharp object
            //goes to postman
        }

        // post send some data
    
        [HttpPost]
        // attribute routing
        public string AddPerson(Person newPerson)
        {
            People.Add(newPerson);
            return "Person Added";
        }

        
        //summary
        //return person in list with matching id
        [HttpPost]
        
        public Person FindPerson(Person findPerson)
        {
            return null;
        }

            

        
    }
}