using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WelcomeBackTasks;

namespace WB_WebApi.Controller
{
    //defalut
    [ApiController]
    [Route("[controller]")]

    public class WB_Controller: ControllerBase
    {
        public WB_Controller()
        {

        }

        [HttpGet("GetPalindromeMin/{decimals}")]
        public int GetMin(int decimals)
        {
            Palindromic p = new Palindromic();
            return p.GetPalindromeMin(decimals);
        }

        [HttpGet("GetPalindromeMax/{decimals}")]
        public int GetMax(int decimals)
        {
            Palindromic p = new Palindromic();
            PalindromeMax(decimals);
            //error
        }

        [HttpGet("GetRemainder/{limit}")]
        public int GetRemainder(int limit)
        {
            Divided d = new Divided();
            return d.RemainderCheck(limit);
        }



    }
}