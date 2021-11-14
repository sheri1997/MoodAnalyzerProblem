using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace MoodAnalyzerMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class UnitTest1  //here performed the unit testing for class
        {

            MoodAnalyzerFactory factory = null;

            [TestInitialize]
            public void SetUp()
            {
                factory = new MoodAnalyzerFactory();
            }

            [TestMethod]
            public void AnalyseHappyMood()
            {
                // Test Case 1
                //Arrange
                string message = null;
                string expected = "happy";

                //Act
                MoodAnalyzer MoodAnalyzer = new MoodAnalyzer(message);
                string actual = MoodAnalyzer.AnalyzeMood();

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [TestMethod]
            public void getCustomNullException()
            {
                //Arrange
                string expected = "Message Should Not Be Null";
                MoodAnalyzer MoodAnalyzer = new MoodAnalyzer(null);

                try
                {
                    //Act
                    string actual = MoodAnalyzer.AnalyzeMood();

                }
                catch (CustomException ex)
                {

                    //Assart
                    Assert.AreEqual(expected, ex.Message);
                }

            }

            /// <summary>
            /// UC4
            /// Reflections the using default constructor.
            /// </summary>
            /// <exception cref="System.Exception"></exception>
            [TestMethod]
            public void ReflectionUsingDefaultConstructor()
            {
                MoodAnalyzer expected = new MoodAnalyzer();
                object obj = null;
                try
                {
                    obj = factory.createMoodAnalyzerObject("MoodAnalyzarProblem.MoodAnalyzer", "MoodAnalyzer");

                }
                catch (CustomException ex1)
                {
                    throw new Exception(ex1.Message);
                }
                obj.Equals(expected);
            }

            /// <summary>
            /// UC5
            /// Gets the mood Analyzer using parametre constructor.
            /// TC5.1
            /// </summary>
            /// <exception cref="System.Exception"></exception>
            [TestMethod]
            public void getMoodAnalyzerUsingParametreConstructor()
            {
                string message = "I am in happy mood";
                MoodAnalyzer expected = new MoodAnalyzer(message);
                object actual = null;
                try
                {
                    MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
                    //act
                    actual = factory.CreateMoodAnalyzerParameterObject("MoodAnalyzer", "MoodAnalyzer", message);

                }
                catch (CustomException exception)
                {
                    throw new Exception(exception.Message);
                }
                actual.Equals(expected);
            }

            /// <summary>
            /// Gets the mood Analyzer using parametre constructor1.
            /// UC5 
            /// TC5.2 Pass wrong class name
            /// </summary>
            /// <exception cref="System.Exception"></exception>
            [TestMethod]
            public void getMoodAnalyzerUsingParametreConstructorPassWrongClassName()
            {
                string message = "I am in happy mood";
                MoodAnalyzer expected = new MoodAnalyzer(message);
                object actual = null;
                try
                {
                    MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
                    //act
                    actual = factory.CreateMoodAnalyzerParameterObject("MoodAnalyzer123", "MoodAnalyzer", message);

                }
                catch (CustomException exception)
                {
                    throw new Exception(exception.Message);
                }
                actual.Equals(expected);
            }

            /// <summary>
            /// Gets the mood Analyzer using parametre constructor pass wrong constructor.
            ///  UC5  TC5.5
            /// </summary>
            /// <exception cref="System.Exception"></exception>
            [TestMethod]
            public void getMoodAnalyzerUsingParametreConstructorPassWrongConstructor()
            {
                string message = "I am in happy mood";
                MoodAnalyzer expected = new MoodAnalyzer(message);
                object actual = null;
                try
                {
                    MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
                    //act
                    actual = factory.CreateMoodAnalyzerParameterObject("MoodAnalyzer", "MoodAnalyzerconstrcutor", message);

                }
                catch (CustomException exception)
                {
                    throw new Exception(exception.Message);
                }
                actual.Equals(expected);
            }

            [TestMethod]
            public void testMoodAlalyserUisngInvokeMethod()
            {
                string message = "Happy";
                string methodName = "AnalyseMood";
                string expected = "Happy";
                string actual = " ";
                try
                {
                    MoodAnalyzerFactory factory = new MoodAnalyzerFactory();

                    actual = factory.InvokeAnalyzerMethod(message, methodName);
                }
                catch (CustomException exception)
                {
                    throw new Exception(exception.Message);

                }
                Assert.AreEqual(expected, actual);

            }
        }
}
