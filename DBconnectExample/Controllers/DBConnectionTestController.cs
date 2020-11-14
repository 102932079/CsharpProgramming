//find compelete guide from microsoft document
//https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection?view=dotnet-plat-ext-5.0
//or
//https://www.guru99.com/c-sharp-access-database.html

using System;
using Microsoft.AspNetCore.Mvc;//for db -re 
using System.Data.SqlClient; //sqlconnection

//we need sql connection string and read block

//namespace issue
namespace DBCONNECTEXAMPLE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DBConnectionTestController
    {
        [HttpGet]
        public string TestConnection(){
            //not reconise connection dont have the libery try (dotnet restore)
            //ctrl + shift P console runner NuGet Package Manager: add package
            //need to download Nuget Package Manager in extension
            //system.data.sqlclient
            //sample DB URL from Anh
            //bikestoresdb.c3raologixkl.us-east-1.rds.amazonaws.com
            //the sample DB from dofactory.com/sql/sample-database
            String ConnectionString = @"Data Source=bikestoresdb.c3raologixkl.us-east-1.rds.amazonaws.com;Initial Catalog=SampleDB;User ID=admin;Password=abcd1234";
            //above was connection string
            SqlConnection conn = new SqlConnection();
            SqlConnection cnn;
        }
    }
}
