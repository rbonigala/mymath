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
        public Basic twoNumberQuestion = new Basic();


        Array operations = Enum.GetValues(typeof(BasicOperation));

        [BindProperty]
        public string Status
        {
            get;
            set;
        }

       
        [BindProperty]
        public Basic CurrentQuestion
        {
            get; set;

        }
    

        public IActionResult OnGet()
        {
            Calculate calculate = new Calculate();
            CurrentQuestion = calculate.SimpleCalculation(CurrentQuestion);
            return Page();
        }



        public IActionResult OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            if(CurrentQuestion.LeftNumber + CurrentQuestion.RightNumber == CurrentQuestion.Result)
            {
                Status = "Correct";
            }
            else
            {
                Status = "Please Try";
            }


            return RedirectToPage();
        }
    }
}