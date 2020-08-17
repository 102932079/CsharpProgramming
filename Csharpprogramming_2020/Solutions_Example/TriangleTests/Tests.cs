using System;
using Xunit;
using TriangleLib;

namespace TriangleTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3.0, 2.0, 3.0)]
        [InlineData(7.5, 3.0, 5.0)]
        [InlineData(13.5, 9.0, 3.0)]
        public void CalcArea_Test(double expected, double @base, double height)
        {
            RightAngledTriangle rt = new RightAngledTriangle(@base, height);

            Assert.Equal(expected, rt.CalcArea());    
        }

        [Theory]
        [InlineData(12.0, 4.0, 3.0)]
        [InlineData(18.81, 5.0, 6.0)]
        public void CalcPerimeter_Test(double expected, double @base, double height) {
            RightAngledTriangle rt = new RightAngledTriangle(@base, height);

            Assert.Equal(expected, rt.CalcPerimeter()); 
        }

        [Fact]
        public void RoundingTest() {
            RightAngledTriangle rt = new RightAngledTriangle(7.0, 6.0);

            Assert.NotEqual(24.576, rt.CalcPerimeter());
        }
    }
}
