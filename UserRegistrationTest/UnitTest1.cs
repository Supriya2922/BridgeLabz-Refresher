using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_FirstName()
        {
            Program obj= new Program();
            bool res = obj.firstName("Supriya");
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void Test_LastName()
        {
            Program obj = new Program();
            bool res = obj.firstName("Prak");
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void Test_email()
        {
            Program obj = new Program();
            bool res = obj.email("sup.roy@su.co.in");
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void Test_PhoneNo()
        {
            Program obj = new Program();
            bool res = obj.phone("91 7892635242");
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void Test_password()
        {
            Program obj = new Program();
            bool res = obj.password("Lupp19cs!");
            Assert.IsTrue(res);
        }

    }
}