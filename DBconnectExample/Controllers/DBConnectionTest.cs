//find compelete guide from microsoft document
//https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection?view=dotnet-plat-ext-5.0
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
