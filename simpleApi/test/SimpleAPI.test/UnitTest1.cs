using System;
using Xunit;
using SimpleApi.Controllers;

namespace SimpleAPI.test
{
    public class UnitTest1
    {

        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnMy()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Ayehsa", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
