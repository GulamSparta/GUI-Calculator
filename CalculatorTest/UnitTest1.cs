using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;


namespace CalculatorMSTest
{
    [TestClass]
    public class UnitTest1
    {       //Make sure you never repeat some of the code!!!!
        [TestInitialize]
        public void Initialize()
        {
            var clc = new Calculator.Calculator();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Calculator.Calculator clc = new Calculator.Calculator();

            //seup
            double valueInputOne = 5;
            double valueInputTwo = 2;
            double expectedOutPut = 5;
            //(10/2)

            //running the test

            //Divide
            double result = clc.Divide(valueInputOne, valueInputTwo);
            Assert.AreEqual(2.5, result);
        }
        public class MultiplyValue
        {
            public void TestMultiply()
            {
                Calculator.Calculator clc = new Calculator.Calculator();

                //seup
                double valueInputOne = 6;
                double valueInputTwo = 2;
                double expectedOutPut = 5;

                //Multiply
                double result = clc.Multiply(valueInputOne, valueInputTwo);
                Assert.AreEqual(12, result);
            }
        }

    }
    public class AddValue
    {
        public void TestAdd()
        {
            Calculator.Calculator clc = new Calculator.Calculator();

            //seup
            double valueInputOne = 6;
            double valueInputTwo = 2;
            double expectedOutPut = 8;

            //Multiply
            double result = clc.Add(valueInputOne, valueInputTwo);
            Assert.AreEqual(8, result);
        }

        [TestCleanup]
        public void CleanUpMethod()
        {
            //clc = null; //or do something if necessary after test
        }


    }
}