using CarInvoiceGenerator;

namespace CabInvoiceTest
{
    [TestClass]
    public class InvoiceTest
    {

        [TestMethod]
        public void GivenLessDistanceAndTime_ReturnMinimumFare()
        {
            CalculateInvoice invoice = new CalculateInvoice();
            double distance = 0.2;
            int time = 1;
          
            double expectedFare = 5;
            double testFare = invoice.CalculateFare(distance, time);
            Assert.AreEqual(expectedFare, testFare);
        }
        [TestMethod]
        public void GivenDistanceAndTime_ReturnTotalFare()
        {
            CalculateInvoice invoice = new CalculateInvoice();
            double distance = 30.0;
            int time = 45;
            invoice.CalculateFare(distance, time);
            double expectedFare = 345;
            double testFare=invoice.CalculateFare(distance, time);
            Assert.AreEqual(expectedFare, testFare);
        }
        [TestMethod]
        public void GivenMultipleRides_ReturnAggregateTotalFare()
        {
           
            Ride ride1 = new Ride(3, 2);
            Ride ride2=new Ride(5, 4);
            Ride ride3=new Ride(6, 7);
            string userid = "Supriya";
            List<Ride> ride=new List<Ride> { ride1, ride2, ride3};
            double expectedTotal = 153;
            User.AddUserRides(userid , ride);
            CabInvoice obj=new CabInvoice();
            CalculateInvoice invoice = obj.GetInvoice(userid);
            double totalFare = invoice.totalFareForAllRides;
            Assert.AreEqual(expectedTotal, totalFare);

        }
        [TestMethod]
        public void GivenUserId_ReturnInvoice()
        {

            Ride ride1 = new Ride(3, 2);
            Ride ride2 = new Ride(5, 4);
            Ride ride3 = new Ride(6, 7);
            string userid = "Max";
            List<Ride> ride = new List<Ride> { ride1, ride2, ride3 };
            
            User.AddUserRides(userid, ride);
            CabInvoice obj = new CabInvoice();
            CalculateInvoice invoice = obj.GetInvoice(userid);
            double expectedTotal = 153;
            int expectedTotalNumOfRides = 3;
            double expectedAverge = 51;
            double totalFare = invoice.totalFareForAllRides;
            double averageFare = invoice.averageFare;
            double totalRides = invoice.totalNumOfRides;
            Assert.AreEqual(expectedTotal, totalFare);
            Assert.AreEqual(expectedAverge, averageFare);
            Assert.AreEqual(expectedTotalNumOfRides, totalRides);

        }
        [TestMethod]

        public void GivenPremium_ReturnInvoice()
        {
            Ride ride1 = new Ride(3, 5,"premium");
            Ride ride2 = new Ride(4, 6, "premium");
            Ride ride3 = new Ride(3, 2,"normal");
            string userid = "Rose";
            List<Ride> ride = new List<Ride> { ride1, ride2, ride3 };
            User.AddUserRides(userid, ride);
            CabInvoice obj = new CabInvoice();
            CalculateInvoice invoice = obj.GetInvoice(userid);
            double expectedTotal = 159;
            int expectedTotalNumOfRides = 3;
            double expectedAverge = 53;
            double totalFare = invoice.totalFareForAllRides;
            double averageFare = invoice.averageFare;
            double totalRides = invoice.totalNumOfRides;
            Assert.AreEqual(expectedTotal, totalFare);
            Assert.AreEqual(expectedAverge, averageFare);
            Assert.AreEqual(expectedTotalNumOfRides, totalRides);

        }
        [TestMethod]
        public void GivenPremiumLessDistanceAndTime_ReturnMinimumFare()
        {
            CalculateInvoice invoice = new CalculateInvoice();
            double distance = 0.2;
            int time = 1;
           
            double expectedFare = 20;
            double testFare = invoice.CalculateFare(distance, time,"premium");
            Assert.AreEqual(expectedFare, testFare);
        } 
    }
}