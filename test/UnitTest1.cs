using System;
using backend.Controllers;
using backend.Models;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void ReturnSingleValue() {
            Value expectedResult = new Value { Id = 1, Name = "Value1"};
            Value returnValue = controller.GetValueById(1);
            Assert.Equal(expectedResult.Id, returnValue.Id);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
