using System;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DBConnectionTestController
    {
        [HttpGet]
        public string TestConnection(){
            
        }
    }
}
