using System;
using CalcLib;
using Xunit;

namespace Tests 
{

    // Create Unit Tests using xUnit for the methods FibonnacciRec
    public class UnitTest1 
    {
        RecursiveCalc r = new RecursiveCalc ();
        [Fact]
        public void FibonacciRec_Test_Fact ()
        {
            int num1 = 1;
            int num2 = 2;
            int numFibs = 3;
            Assert.Equal (41, r.FibonacciRec (num1, num2, numFibs));
        }

    }

    // Create Unit Tests using xUnit for the methods FactorialRec 
    public class UnitTest2 
    {
        RecursiveCalc r = new RecursiveCalc ();
        [Fact]
        public void FactorialRec_Test_Fact () 
        {
            int input = 4;
            int ans = 3;
            Assert.Equal (72, r.FactorialRec (input, ans));
        }

        [Theory]
        [InlineData (3, 2, 12)]
        [InlineData (2, 1, 2)]
        public void FactorialRec_Test_Theory (int input, int ans, int expected) 
        {
            var factorialRecResult = r.FactorialRec (input, ans);
            Assert.Equal (expected, factorialRecResult);
        }
    }

    // Create Unit Tests using xUnit for the methods FibCheck
    public class UnitTest3 
    {
        RecursiveCalc r = new RecursiveCalc ();
        [Fact]
        public void FibCheck_Test () 
        {
            int num = 8;
            bool fibCheckResult = true;
            Assert.Equal (fibCheckResult, r.FibCheck (num));
        }
    }

    // Create Unit Tests using xUnit for the methods PrimeCheckRec 
    public class UnitTest4 
    {
        RecursiveCalc r = new RecursiveCalc ();
        [Fact]
        public void PrimeCheckRec_Test () 
        {
            int num = 1;
            int divisor = 1; 
            bool primecheckrecresult = true;            
            Assert.Equal (primecheckrecresult, r.PrimeCheckRec(num, divisor));
        }

    }
    // Test for a DivideByZeroException when PrimeCheckRec is initialised with a divisor of 0
    public class UnitTest5 
    {
        RecursiveCalc r = new RecursiveCalc ();
        [Fact]
        public void PrimeCheckRec_DivideByZeroException_Test () 
        {
            int num = 1;
            int divisor = 0;            
            Assert.Throws<DivideByZeroException> (() => r.PrimeCheckRec (num, divisor));
            var ex = Assert.Throws<DivideByZeroException> (() => r.PrimeCheckRec (num, divisor));
            Assert.Equal ("Attempted to divide by zero.", ex.Message);
        }

    }

}