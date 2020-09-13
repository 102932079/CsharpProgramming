using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackMe
{
    class Program
    {

        public static string RunFileToCrack(string username, string password)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "CrackMe_File.exe",
                    Arguments = username + " " + password,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                return line;
            }
            return "File did not respond";
            
        }

        static void Main(string[] args)
        {
            string output = RunFileToCrack("frank@dumb.com", "123");

            Console.WriteLine(output);
            Console.ReadKey(true);
        }
    }
}
