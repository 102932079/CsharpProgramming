using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
// controllers is for provide connections
// when everytime we created webapi the system also will create this demo weatherforecast api
// when we trying to create new controller just create a new class in c sharp

//there is no easy way to create controller just goes to weatherforecast and strip it out
namespace WebApi_DEMO.Controllers
{
    [ApiController]
    // we can run mutiple controller
    [Route("[controller]")]
    // class name + controller 
    // url / weather forecast 
    public class WeatherForecastController : ControllerBase
    {
        //array list
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public string Get()
        {
            return Summaries[0];
        }


        // api not like console will constant running, to shut it down just ctrl + c


        // public IEnumerable<WeatherForecast> Get()
        // {
        //     var rng = new Random();
        //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //     {
        //         Date = DateTime.Now.AddDays(index),
        //         TemperatureC = rng.Next(-20, 55),
        //         Summary = Summaries[rng.Next(Summaries.Length)]
        //     })
        //     .ToArray();
        // }
    }
}
