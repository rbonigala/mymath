using System;
using MyMath.Interfaces;

namespace MyMath.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Calculate : ICalculate
    {

        public Calculate()
        {

        }

        Random randomNumber = new Random();

        public Basic SimpleCalculation(Basic basicQuestion)
        {
            switch (basicQuestion.Operation)
            {
                case '+':
                    basicQuestion.Result = basicQuestion.LeftNumber + basicQuestion.RightNumber;
                    break;
                case '-':
                    if (basicQuestion.LeftNumber < basicQuestion.RightNumber)
                    {
                        var tmpNumber = basicQuestion.LeftNumber;
                        basicQuestion.LeftNumber = basicQuestion.RightNumber;
                        basicQuestion.RightNumber = tmpNumber;
                    }
                    basicQuestion.Result = basicQuestion.LeftNumber - basicQuestion.RightNumber;
                    break;
                default:
                    break;
            }
            return basicQuestion;
        }
    }
}
