using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInvoiceGenerator
{
   public class User
    {
        public static Dictionary<string,List<Ride>> userAccount=new Dictionary<string,List<Ride>>();
        public static void AddUserRides(string userid,List<Ride> rides)
        {
            if(userAccount.ContainsKey(userid))
            {
                foreach(Ride ride in rides)
                {
                    userAccount[userid].Add(ride);
                }
            }
            else
            {
                userAccount.Add(userid,rides);
            }
        }
    }
}
