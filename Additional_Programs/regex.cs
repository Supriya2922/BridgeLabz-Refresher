using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Additional_Programs
{
    internal class regex
    {
        public static void regexFunc()
        {
            
            String name = "<<name>>";
            String fullname = "<<full name>>";
            String mobno = "91-xxxxxxxxxx";
            String date = @"\d\d/\d\d/\d\d\d\d";
            String msg = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx.Please,let us know in case of any clarification Thank you BridgeLabz 01/01/2016.";
           
            Regex p = new Regex(name);
           
            MatchEvaluator eval = new MatchEvaluator(ReplaceName);
            msg =p.Replace(msg, eval);
            p=new Regex(fullname);
            eval = new MatchEvaluator(ReplaceFullName);
            msg = p.Replace(msg, eval);
            p = new Regex(mobno);
            eval = new MatchEvaluator(ReplaceMobNumber);
            msg = p.Replace(msg, eval);
            p = new Regex(date);
            eval = new MatchEvaluator(ReplaceDate);
            msg = p.Replace(msg, eval);
            Console.WriteLine(msg);
        }
        public static string ReplaceName(Match m)
        {
            
            return "Supriya";
        }
        public static string ReplaceFullName(Match m)
        {
            return "Supriya" +" "+"P";
        }
        public static string ReplaceMobNumber(Match m)
        {
            return "+91-7892543267";
        }
        public static string ReplaceDate(Match m)
        {
            return "23/2/2023";
        }

    }
}
