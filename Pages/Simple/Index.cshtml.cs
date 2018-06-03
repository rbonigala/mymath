using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MyMath.Models;

namespace MyMath.Pages.Simple
{
    public class IndexModel : PageModel
    {  
        public Basic twoNumberQuestion;
        Random leftRandomNumber = new Random();
       
        public void OnGet()
        {
            leftRandomNumber.Next();
            twoNumberQuestion = new Basic();
            twoNumberQuestion.LeftNumber = leftRandomNumber.Next(10);
            twoNumberQuestion.RightNumber = leftRandomNumber.Next(10);
        }
    }
}