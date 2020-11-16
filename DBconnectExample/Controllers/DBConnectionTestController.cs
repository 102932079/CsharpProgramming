//find complete guide from microsoft document
//https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection?view=dotnet-plat-ext-5.0
//or
//https://www.guru99.com/c-sharp-access-database.html

using System;
using Microsoft.AspNetCore.Mvc;//for db -re 
using System.Data.SqlClient; //sqlconnection
using System.Collections.Generic;//array
using DBCONNECTEXAMPLE.models;//class
using Microsoft.Extensions.Configuration;

//somehow the library is so broken //sometime you can use reload windows to fix some issue
//!ctrl + shift + F find words in term 
//we need sql connection string and read block
//sql connect and sql data reader

//namespace issue
namespace DBCONNECTEXAMPLE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DBConnectionTestController
    {
        //*make a class variable instend of URL, this is the access variable for only this class DBConnectionTestController
        //*for advance define it in the appsetting json
        //!under api repo properties got launchsettings.json can define the local host port in there 
        //!put the access variable which contain sensitive info in codences in appsettings or put in environment variable and hide it
        //*the code base is same not the connection string are different
        //json file don't need to save it keep the change itself
        //tell the system where to find the access connection string
        //+String connectionString = @"Data Source=bikestoresdb.c3raologixkl.us-east-1.rds.amazonaws.com;Initial Catalog=SampleDB;User ID=admin;Password=abcd1234";
        //instend use this //using Microsoft.Extensions.Configuration;private, not inits

        SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
        IConfiguration configuration;
        //this got different way to inits configuration builder in start cs
        string connectionstring = "";//inits

        //ctor
        public DBConnectionTestController(IConfiguration iConfig){
            //auto pass data
            this.configuration = iConfig;
            //*use configuration to retrieve connection string from appsetting.json
            this.connectionstring = this.configuration.GetSection("ConnectionString").Value;
            //*get section like a object

            // !use the SqlConnectionStringBuilder to create our connection string() add element one by one
            //data type need convert to string so value
            stringBuilder.DataSource = this.configuration.GetSection("DBConnectionString").GetSection("Url").Value;
            stringBuilder.InitialCatalog = this.configuration.GetSection("DBConnectionString").GetSection("Database").Value;
            stringBuilder.UserID = this.configuration.GetSection("DBConnectionString").GetSection("User").Value;
            stringBuilder.Password = this.configuration.GetSection("DBConnectionString").GetSection("Password").Value;

            this.connectionstring = stringBuilder.ConnectionString;
            //little things changed in connection string will the cruash the system
        }
        
        [HttpGet]
        public List<Customer> TestConnection() { //return type need to be a list of customer//string List<Customer>
            //*create a list of customer
            List<Customer> customers = new List<Customer>();//import array function and class from models

            //!quick recap go on to NuGet and grab that library (dotnet restore) for sql client then work out connection string
            //!the connect string have host and what database name address then the login detain username and password

            //not recognize connection don't have the library try (dotnet restore)
            //ctrl + shift P console runner NuGet Package Manager: add package
            //need to download Nuget Package Manager in extension
            //system.data.sqlclient
            //sample DB URL from Anh
            //bikestoresdb.c3raologixkl.us-east-1.rds.amazonaws.com
            //the sample DB from dofactory.com/sql/sample-database
            //connect to DB not provider
            //`Connect to an SQL Server Database
            //*not a good place to put connectionstring need refine it to other place,visibility(infomation secure)when URL change need manually change it
            //*use variable for it see above for each end point
            //String connectionString = @"Data Source=bikestoresdb.c3raologixkl.us-east-1.rds.amazonaws.com;Initial Catalog=SampleDB;User ID=admin;Password=abcd1234";
            
            //!quick recap crate connection to that database create query and send command

            //the url will be shutted down soon
            //above was connection string
            //*if i do need to change the connection string i just need to go to appsetting and change it at once
            //`for RPS project do seprate for user and selection
            //one step further for the selector
            //break the long part into 3 separate section (source, catalog, userID,Password) change individually instead whole
            SqlConnection conn = new SqlConnection(this.connectionString);
            //SqlConnection cnn;
            string queryString = "Select * From Customer";
            //`use sqlcommand to open up a connection
            SqlCommand command = new SqlCommand ( queryString, conn);
            conn.Open();
            string result = "";

            //!recap using reader
            //`data reader
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    //reader column and add to array
                    result += reader[0] + "|" + reader[1] + reader[2] + "\n";//by add "\n" give the return data for each row to start a new line
                    //id | Lastname and surname 
                    //create new custom

                    //this line is important to turning the data into sth useful for the our webapi
                    customers.Add(
                        new Customer() { Id = reader[0], FirstName = reader[1].ToString(), surname = [2].ToString()}
                        );

                }
            }
            
            //return a method ok // if connect success return ok in postman
            //return "Ok";
            return customers; //json .net cores does

            //16 error CS0579: Duplicate (cant fix)
            //dotnet build (grab the url which is listening on port)
            //https://localhost:5001/DBConnectionTest return ok 


            //// List<Customer> customers = new List<Customer>();

            //// Connect to an SQL Server Database
            //string connectionString = @"Data Source=bikestoresdb.c3raologixkl.us-east-1.rds.amazonaws.com;Initial Catalog=SampleDB;User ID=admin;Password=abcd1234";
            //SqlConnection conn = new SqlConnection(connectionString);

            //string queryString = "Select * From Customer";

            //SqlCommand command = new SqlCommand( queryString, conn);
            //conn.Open();
                    
            //string result = "";
            //using(SqlDataReader reader = command.ExecuteReader())
            //{
            //                 while (reader.Read())
            //                 {
            //                     result += reader[0] + " | " + reader[1] + reader[2] + "\n";
                                
            //                     // ORM - Object Relation Mapping
            //                     customers.Add(
            //                         new Customer() { Id = (int)reader[0], FirstName = reader[1].ToString(), Surname = reader[2].ToString()});                
            //                 }
            //             }

            //pratice:
            //endpoint which returns:
            //list of objects - product name, unit price suppliername
            //with the sample DB
            
        }

        
        //`SqlCommand class
        //https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand?view=dotnet-plat-ext-5.0
        //CURD in sql list
        //insert is create, select is read, delete is delete,  update is insert again
        //comand.excuteNonquery(); // write data

        //`create another endpoint for write data in database
        [HttpGet("Delete91")]

        public string Delete91(){
            //`connect DB
            //string connectionString = @"Data Source=bikestoresdb.c3raologixkl.us-east-1.rds.amazonaws.com;Initial Catalog=SampleDB;User ID=admin;Password=abcd1234";
            SqlConnection conn = new SqlConnection(connectionString);

            string queryString = "Delete From Customer Where Id=91";

            //`create a sql command - loading the query into the command
            SqlCommand command = new SqlCommand(queryString, conn);

            //`accese the connection
            conn.Open();

            try {
                var result = command.ExecuteNonQuery();
                return result.ToString();
            } catch (SqlException se) {
                return "Cannot delete user with id 91" + se.Message;
            }
            

            

            //return error use try catch

        }
    }
}

