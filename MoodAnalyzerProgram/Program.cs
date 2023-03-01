
namespace MoodAnalyzerProgram
{
    public class MoodAnalyzer
    {
        public string Mood(String sentence) 
        {
            String res = "";
            try
            {
                if(sentence == "")
                {
                    throw new InValidMoodException(ExceptionType.ENTERED_EMPTY, "Empty mood");
                }
                if(sentence.Contains("happy") || sentence.Contains("Happy"))
                {
                    res = "Happy";
                   
                }
                else if (sentence.Contains("sad") || sentence.Contains("Sad"))
                {
                    res = "Sad";
                   
                }
                else if(!sentence.Contains("happy") && !sentence.Contains("sad"))
                {
                    throw new InValidMoodException(ExceptionType.ENTERED_NULL,"Null mood(Neither happy or sad)");
                    
                }
               
            }
            catch(InValidMoodException e)
            {
                
                if (e.typeoferror == ExceptionType.ENTERED_NULL)
                { res = "Happy";
                    Console.WriteLine("Message :" + e.Message);
                }
                else if(e.typeoferror == ExceptionType.ENTERED_EMPTY)
                    Console.WriteLine("Message :" + e.Message);
            }
           
            return res;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
           
        }
    }
}