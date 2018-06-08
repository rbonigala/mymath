using System;


namespace MyMath.Models
{
    public class Basic : IQuestion
    {
        public long LeftNumber {get; set;}

        public long RightNumber { get; set; }

        public long Result { get; set; }    

        public BasicOperation Operation {get; set;}

        private string questionName;

        public string Name 
        { 
            get{
                return questionName;
            } 
            set{
                questionName = "Basic Two Number Question";
            } 
        }
    }
    
}