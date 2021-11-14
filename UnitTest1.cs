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
            
            string message = "I am in Sad Mood";
            string expectedMessage = "SAD";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string actualMessage = mood.analyseMood();
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
