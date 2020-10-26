using System;
using Xunit;
// reference class using class lib
using MaskApi.models;

namespace MaskTests
{
    public class MaskTests
    {
        [Fact]
        public void ConstructorTest()
        {
            // and also we need to reference before testing
            // that mask() should not working beacuse this is no default constctor here
            //Mask newMask = new Mask();
            // should using try catch
            // try the commend
            // fix it by declaring it here and make it null
            Mask newMask = null;

            try
            {
                // newmask will error out if it is using problem
                //the new mask only exist in two mastshs between {} it wont exist outside
                newMask = new Mask("m-9999", 1, "White", true, false, "Flowers", true, 10.00);

            }
            // an exception type
            catch (Exception ex)
            // throw a exception we cant print due to no console
            {
                // we can throw again but system will catch it throw ex;
                System.Environment.Exit(1);

                // dotnet test for testing


            }
            //Assert.True(true);
            Assert.True(newMask.New); 
            //system new mask doesnot exists

        }
    }
}
