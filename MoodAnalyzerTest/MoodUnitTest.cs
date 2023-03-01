using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProgram;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void TestHappy()
        {
            MoodAnalyzer obj=new MoodAnalyzer();
            String res = obj.Mood("I am happy");
            Assert.AreEqual(res, "Happy");
        }
        [TestMethod]
        public void TestSad()
        {
            MoodAnalyzer obj = new MoodAnalyzer();
            String res = obj.Mood("I am very sad");
            Assert.AreEqual(res, "Sad");
        }
        [TestMethod]
        public void TestEmpty()
        {
            MoodAnalyzer obj = new MoodAnalyzer();
            String res = obj.Mood("");
            Assert.AreEqual(res, "");
        }
        [TestMethod]
        public void TestNull()
        {
            MoodAnalyzer obj = new MoodAnalyzer();
            String res = obj.Mood("I am very bad");
            Assert.AreEqual(res, "Happy");
        }
    }
}