
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    public class LongestSubstring
    {
        public void findSubstring(String str)
        {
            char[] ch = str.ToCharArray();
            int maxi = int.MinValue;
            int start = 0;
            Dictionary<char,int> map = new Dictionary<char, int>();
            for(int e = 0; e < str.Length; e++)
            {
                if (map.ContainsKey(ch[e]))
                {
                    start=Math.Max(start, map[ch[e]]+1);
                    
                }

                map[ch[e]] = e;
                maxi = Math.Max(maxi, e - start + 1);
            }
            Console.WriteLine("Length of the longest substring without repeating characters:"+maxi);
        }
    }
}
