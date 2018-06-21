using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MyMath.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class QuestionAndAnswer
    {
        public static Basic BasicQuestion
        {
            get
            {
                Random randomNum = new Random();
                Basic CurrentQuestion = new Basic();
                CurrentQuestion.LeftNumber = randomNum.Next(10);
                CurrentQuestion.RightNumber = randomNum.Next(10);

                switch (randomNum.Next(1, 3))
                {
                    case 1:
                        CurrentQuestion.Operation = '+';
                        break;
                    case 2:
                        CurrentQuestion.Operation = '-';
                        break;
                    default:
                        break;
                }
                return CurrentQuestion;
            }

            
        }

        public string Answer 
        {
            get;
            set;
        }

    }


}
