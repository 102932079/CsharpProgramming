using System;
using Xunit;
using PersonLib;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Person p1 = new Person();
            p1.Name = "Big Bob";
            p1.YearOfBirth = 1970;

            Person p2 = new Person();
            p2.Name = "Big Bob";
            p2.YearOfBirth = 1971;

            Person p3 = new Person();
            p3.Name = "Big Bob";
            p3.YearOfBirth = 1972;

            Assert.Equal(50, p1.CalcAge());
            Assert.Equal(49, p2.CalcAge());
            Assert.Equal(48, p3.CalcAge());
        }

        [Theory]
        [InlineData(50, 1970)]
        [InlineData(49, 1971)]
        [InlineData(48, 1972)]
        public void GetAge_Test(int expected, int yob) {
            Person p1 = new Person();
            p1.Name = "Big Bob";
            p1.YearOfBirth = yob;

            Assert.Equal(expected, p1.CalcAge());
        }

        [Fact]
        public void  GetAge_ExceptionTest() {
            Person p1 = new Person();
            p1.Name = "Big Bob";
            p1.YearOfBirth = 1899;

            Assert.Throws<Exception>(() => p1.CalcAge());

            var ex = Assert.Throws<Exception>(() => p1.CalcAge());

            Assert.Equal("You're too old to be alive.  Unless you are James Hallinan", ex.Message);
        }
    }
}
