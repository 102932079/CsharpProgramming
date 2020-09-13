using System;
using Xunit;
using ClassApi.models;
//beware there are different between add referent to solution and test
//dotnet sln add <references> 
//dotnet add reference <references>

namespace ClassTest
{
    public class ClassroomTests
    {
        [Fact]
        public void ConstructorTests()
        {
            Classroom newRecord1 = null;
            try
            {
                var newRecord1 = new Classroom("TD224", "John Doe");

            }
            catch(Exception)
            {
                System.Environment.Exit(1);
            }

            Assert.Equal("TD224", newRecord1.RoomNumber);
            Assert.Equal("John Doe", newRecord1.Name);

        }

        [Fact]
        public void GetStayedTimeTests()
        {
            Classroom newRecord2 = null;
            var newRecord2 = new Class("AGSE111", "Jane Black"); 

            DateTime  DTEntry = new DateTime(2020,09,13,12,00,00);
            DateTime  DTExit = new DateTime(2020,09,13,17,00,00);

            newRecord2.Entry = DTEntry;
            newRecord2.Exit = DTExit;

            double testDuration = newRecord2.GetStayedTime();

            Assert.Equal(300.00, testDuration);
        }


    }
}
