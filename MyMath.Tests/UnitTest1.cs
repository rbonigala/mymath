using System;
using Xunit;
using MyMath.Models;

namespace MyMath.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
             Basic inputQuestion = new Basic();
             inputQuestion.LeftNumber = 5;
            inputQuestion.RightNumber = 5;
            inputQuestion.Operation = '+';
            long expectedResult = 10;

            Calculate calc = new Calculate();

            inputQuestion = calc.SimpleCalculation(inputQuestion);

            Assert.Equal(expectedResult, inputQuestion.Result);

        }
    }
}
