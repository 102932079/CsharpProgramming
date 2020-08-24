// dotnet restore
//using Newtonsoft.Json;
using System.Text.Json.Serialization;
namespace TestApi
{
    public class Person
    {
        // the jsonperpertyname need to be same with json file blah.json
        // interpeter into json
        [JsonPropertyName("Name")]
        // property name readable and writable
        public string Name { get; set; }
        //converting id into property
        [JsonPropertyName("ID")]
        public string ID { get; set; }
        [JsonPropertyName("Weight")]

        public int Weight { get; set; }

        //public string Name;
        //public string ID;
        //hot key for property (prop) tab for switching between
        //public int Weight;
        // short cut for generate constructor 'person()'
        public Person()
        {
        }

        // short cut for generate constructor      
        public Person(string name, string iD, int weight)
        {
            this.Name = name;
            this.ID = iD;
            this.Weight = weight;
        }


        
    }
}