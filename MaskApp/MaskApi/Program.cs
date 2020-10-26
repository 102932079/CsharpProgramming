// you can use (mv <oldfoldername> <new foldername>) to rename a folder
// dotnet new sln
// dotnet sln add <url> (to a csproj file)
// you will see new text project - endproject
// we can build mutiple project in solution (purpose to add reference to solution)
// create class lib 
// we build mask before order beacuse we need mask to reference the order
// create folder named model for classlib and dump all the class in the models folder
// git init is for create .git folder for push it later
// git add . 
// git commit -m ""
// or you can use vs code git extension
// dotnet new xunit
// dotnet add reference "" to a csproj file
// dotnet test for testing
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MaskApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
