using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyzerMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyzer mood = new MoodAnalyzer();
            string message = "I am in Any Mood";
            string expectedMessage = "HAPPY";
            string actualMessage = mood.analyseMood(message);
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
