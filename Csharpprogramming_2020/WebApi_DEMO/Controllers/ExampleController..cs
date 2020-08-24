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
    public class ExampleController : ControllerBase
    {
        static public List<Person> People = new List<Person>();

        public ExampleController()
        {
            People.Add(new Person("Jason", "007", 77));
            People.Add(new Person("James", "008", 77));
            People.Add(new Person("Maxwell", "86", 60));
            People.Add(new Person("Unknown", "99", 50));
        }
        //http get from forms GET POST PUT HEAD DELETE PATCH OPTIONS (form request)
        [HttpGet]

        public string Get()
        {
            return "Hello";
        }

        // the http get will recive a message and message url will be "hello"

        [HttpGet("{message}/{name}")]
        // can pass in values in url 

        public string Get(string message, string name)
        {
            return message + " " + name;
            //print that message(parameter)
        }

        [HttpGet("{name}")]

        public string Get(string name)
        {
            return name;
            //print that message(parameter)
        }

        // start a new webapi project: 
        [HttpPost]
        //[where to find this element]
        public string Post([FromBody] Person p)
        {
            Person found = null;
            foreach (var pp in People)
            {
                if (p.ID == pp.ID)
                {
                    found = pp;
                    break;
                }
            }

            if (found != null )
            {
                return found.Name + " " + found.ID;
            }
            else
            {
                return "Not Found";

            }

            

        }
    }
}