using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace MoodAnalyzerMSTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyzerFactory factory = null;

        [TestMethod]
        public void SetUp()
        {
            factory = new MoodAnalyzerProblem.MoodAnalyzerFactory();
        }

        [TestMethod]
        public void AnalyseHappyMood()
        {
            // Test Case 1
            //Arrange
            string message = null;
            string expected = "happy";

            //Act
            MoodAnalyzer modeAnalyzer = new MoodAnalyzer(message);
            string actual = modeAnalyzer.analyseMood();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void getCustomNullException()
        {
            //Arrange
            string expected = "Message Should Not Be Null";
            ModeAnalyzer modeAnalyzer = new ModeAnalyzer(null);

            try
            {
                //Act
                string actual = modeAnalyzer.AnalyzeMood();

            }
            catch (CustomException ex)
            {

                //Assart
                Assert.AreEqual(expected, ex.Message);
            }

        }

        [TestMethod]
        public void ReflectionUsingDefaultConstructor()
        {
            ModeAnalyzer expected = new ModeAnalyzer();
            object obj = null;
            try
            {
                obj = factory.createMoodAnalyserObject("MoodAnalyzarProblem.ModeAnalyzer", "ModeAnalyzer");

            }
            catch (CustomException ex1)
            {
                throw new Exception(ex1.Message);
            }
            obj.Equals(expected);
        }
    }
}
