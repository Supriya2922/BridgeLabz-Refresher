using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInvoiceGenerator
{
    public class CalculateInvoice
    {
        public int totalNumOfRides { get; set; }
        public double totalFareForAllRides { get; set; }
        public double averageFare { get; set; }
        public double CalculateFare(double distance, int timeInMin, string type = "normal")
        {
            RideCategory ridetype = new RideCategory(type);
            double totalFare;
            double minimumFare = ridetype.minimumFare;
            double costperkm = ridetype.costPerkm;
            int costpermin = ridetype.costPerMin;
            totalFare = (distance * costperkm) + (costpermin * timeInMin);
            if (totalFare < minimumFare)
            {
                return minimumFare;
            }
            return totalFare;
        }

        public void CalculateAvgFare()
        {
            this.averageFare = this.totalFareForAllRides / this.totalNumOfRides;
        }

    }

    public class CabInvoice
    {
        public CalculateInvoice GetInvoice(string userid)
        {
            CalculateInvoice invoice = new CalculateInvoice();
            if (User.userAccount.ContainsKey(userid))
            {
                double total = 0;
                int numOfRides = 0;
                foreach (Ride ride in User.userAccount[userid])
                {
                    total += invoice.CalculateFare(ride.distance, ride.time,ride.rideType);
                    numOfRides++;
                }
                invoice.totalNumOfRides = numOfRides;
                invoice.totalFareForAllRides = total;
                invoice.CalculateAvgFare();

            }
            return invoice;
        }

    }


}