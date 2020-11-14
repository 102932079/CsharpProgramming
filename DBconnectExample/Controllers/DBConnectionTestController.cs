//find compelete guide from microsoft document
//https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection?view=dotnet-plat-ext-5.0
//or
//https://www.guru99.com/c-sharp-access-database.html

using System;
using Microsoft.AspNetCore.Mvc;//for db -re 
using System.Data.SqlClient; //sqlconnection

//we need sql connection string and read block
//sql connect and sql data reader

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
            //connect to DB not provider
            String connectionString = @"Data Source=bikestoresdb.c3raologixkl.us-east-1.rds.amazonaws.com;Initial Catalog=SampleDB;User ID=admin;Password=abcd1234";
            //above was connection string
            SqlConnection conn = new SqlConnection(connectionString);
            //SqlConnection cnn;

            string queryString = "Select * From Customer";

            //use sqlcommand to openup a connection
            SqlCommand command = new SqlCommand ( queryString, conn);
            conn.Open();

            string result = "";
            //data reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    //reader column and add to array
                    result += reader[0] + "|" + reader[1] + "\n";//by add "\n" give the return data for each row to start a new line
                }
            }
            
            //return a method ok // if connect success return ok in postman
            return "Ok";

            //16 error CS0579: Duplicate (cant fix)
            //dotnet build (grab the url which is listening on port)
            //https://localhost:5001/DBConnectionTest return ok 
            
        }
    }
}
