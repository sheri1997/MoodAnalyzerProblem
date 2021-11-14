using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message)//parametized constructor.
        {
            this.message = message;
        }
        public MoodAnalyzer()
        {
            Console.WriteLine("default constructor");
        }
        public string analyseMood()//this method will become as no parameter.
        {
            try
            {
                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(NullReferenceException ex)
            {
                throw new CustomException(CustomException.ExceptionType.NUll_Type_Exception, "Message Should Not Be Null");
            }
        }
    }
}
