using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class CouponNumber
    {
        public static void coupon()
        {
            Console.WriteLine("Enter the number of coupons");
            int n = Convert.ToInt32(Console.ReadLine());
            char[] ch = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                int r = (int)(random.NextDouble() * 999999999);
                String str = "";
                while (r > 0)
                {
                    str += ch[r % ch.Length];
                   
                    r /=ch.Length; 
                }
                  
                Console.WriteLine(str);
            }
        }
    }
}
