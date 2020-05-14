using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnMyName()
        {
            var returnValue1 = controller.Get();
            var returnValue2 = controller.Get();
            Assert.Equal("Sree", "Sree");
            
            //CollectionAssert
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
