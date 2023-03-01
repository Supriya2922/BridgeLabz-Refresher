using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram
{
    public enum ExceptionType
    {
        ENTERED_NULL,
        ENTERED_EMPTY
      
    }
    public class InValidMoodException:Exception
    {
       
        public ExceptionType typeoferror;
        public InValidMoodException(ExceptionType type,string message):base(message) 
        {
            this.typeoferror = type;
        }
    }
}
