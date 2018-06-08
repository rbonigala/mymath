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
        public Basic BasicQuestion
        {
            get;
            set;
        }

        public string Answer 
        {
            get;
            set;
        }

    }


}
