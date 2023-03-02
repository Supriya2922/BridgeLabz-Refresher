using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInvoiceGenerator
{
    public class Ride
    {
        public double distance { get; set; }
        public int time { get; set; }
        public string rideType { get; set; }
        public Ride(double distance, int time,string type="normal")
        {
            this.distance = distance;
            this.time = time;
            this.rideType = type;
        }
       
    }
    public class RideCategory
    {
        public double costPerkm { get; set; }
        public int costPerMin { get; set; }
        public double minimumFare { get; set; }
        public RideCategory(string type)
        {
            if(type.ToLower()== "premium") {
                this.costPerMin = 2;
                this.costPerkm = 15;
                this.minimumFare = 20;
            }
            else
            {
                this.costPerMin = 1;
                this.costPerkm = 10;
                this.minimumFare = 5;

            }
        }
    }
}
