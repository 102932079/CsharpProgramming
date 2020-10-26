using System;
using Xunit;
// reference class using class lib
using MaskApi.models;

namespace MaskTests
{
    public class OrderTest
    {
        //create a new mask for testing
        Mask newMask1 = new Mask("m-9999", 1, "White", true, false, "Flowers", true, 10.00);
        Mask newMask2 = new Mask("m-8888", 1, "Black", false, true, "RaceCars", true, 3.50);
        //Mask newMask = new Mask("m-9999", 1, "White", true, false, "Flowers", true, 10.00);
        [Fact]
        public void SetPriceTest()
        {
            // create two new orders
            // there was a problem before due to the order of variable is wrong
            Order order1 = new Order(newMask1, 3);
            Order order2 = new Order(newMask2, 10);
            // excepted, and where it comesfrom
            //we cant test setprice beacuse its void we cant test void
            // that why need to be order1 there 
            // the hot key for undo is ctrl + z
            Assert.Equal(30.00, order1.Price);

            Assert.Equal(35.00, order2.Price);

        }

        [Fact]
        public void GenOrderNoTest()
        {
            // we need to test the randomness for the genertate order number
            // need create order object
            Order order1 = new Order(newMask1, 3);
            Order order2 = new Order(newMask2, 10);

            // there is better way to do this
            // there was a problem before due to method name is wrong
            int num1 = order1.GenOrderNo();
            int num2 = order1.GenOrderNo();
            int num3 = order2.GenOrderNo();
            int num4 = order2.GenOrderNo();

            // check randomness so we dont what the condition below happens

            if(num1 == num2 || num1 == num3 || num1 == num4 || num2 == num3 || num2 == num4 || num3 == num4)
            {
                // case matter need to be lower case not catipal case
                Assert.True(false);
            }
            // check the range
            // they need to be all if , if we use else wont work
            // beacuse it cover all possibility
            // wont happen at same time
            // if(num1 >= 1000 && num1 <= 9999)
            // {
            //     Assert.True(true);
            // }

            // if(num2 >= 1000 && num2 <= 9999)
            // {
            //     Assert.True(true);
            // }

            // if(num3 >= 1000 && num3 <= 9999)
            // {
            //     Assert.True(true);
            // }

            // if(num4 >= 1000 && num4 <= 9999)
            // {
            //     Assert.True(true);
            // }

            if ((num1 >= 1000 && num1 <= 9999) && (num2 >= 1000 && num2 <= 9999) && (num3 >= 1000 && num3 <= 9999) &&(num4 >= 1000 && num4 <= 9999))
            {
                Assert.True(true);
            }
            else
            {
                Assert.True(false);
            }

            // the test wont work why? reference and soluton
            // add masktest csproj into sln
            
            

        }
    }
}


