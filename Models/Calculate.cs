using System;

namespace MyMath.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Calculate
    {

        public Calculate()
        {

        }

        Random randomNumber = new Random();

        public Basic SimpleCalculation(Basic basicQuestion)
        {
            basicQuestion = new Basic();
            basicQuestion.LeftNumber = randomNumber.Next(10);
            basicQuestion.RightNumber = randomNumber.Next(10);

            switch (randomNumber.Next(1, 3))
            {
                case 1:
                    basicQuestion.Operation = '+';
                    basicQuestion.Result = basicQuestion.LeftNumber + basicQuestion.RightNumber;
                    break;
                case 2:
                    basicQuestion.Operation = '-';
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
