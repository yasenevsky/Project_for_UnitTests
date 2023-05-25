using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_min10_min0353()
        {
            //arange
            double x = -10;
            double expected = -0.353;
            //act
            Project_for_UnitTests.Form1 c = new Project_for_UnitTests.Form1();
            double actual = c.Method1(x);
            actual = Math.Round(actual, 3);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod1_min5_3242()
        {
            //arange
            double x = -5;
            double expected = 3.242;
            //act
            Project_for_UnitTests.Form1 c = new Project_for_UnitTests.Form1();
            double actual = c.Method1(x);
            actual = Math.Round(actual, 3);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod1_min3_min020()
        {
            //arange
            double x = -3;
            double expected = -0.020;
            //act
            Project_for_UnitTests.Form1 c = new Project_for_UnitTests.Form1();
            double actual = c.Method1(x);
            actual = Math.Round(actual, 3);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2_0_3()
        {
            //arange
            double x = 0;
            double expected = 3;
            //act
            Project_for_UnitTests.Form1 c = new Project_for_UnitTests.Form1();
            double actual = c.Method2(x);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3_1_0841()
        {
            //arange
            double x = 1;
            double expected = 0.841;
            //act
            Project_for_UnitTests.Form1 c = new Project_for_UnitTests.Form1();
            double actual = c.Method3(x);
            actual = Math.Round(actual, 3);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3_7_0657()
        {
            //arange
            double x = 7;
            double expected = 0.657;
            //act
            Project_for_UnitTests.Form1 c = new Project_for_UnitTests.Form1();
            double actual = c.Method3(x);
            actual = Math.Round(actual, 3);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3_12_min0537()
        {
            //arange
            double x = 12;
            double expected = -0.537;
            //act
            Project_for_UnitTests.Form1 c = new Project_for_UnitTests.Form1();
            double actual = c.Method3(x);
            actual = Math.Round(actual, 3);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDoubleRes_15_30()
        {
            //arange
            double x = 15;
            double expected = 30;
            //act
            Project_for_UnitTests.Form1 c = new Project_for_UnitTests.Form1();
            double actual = c.DoubleRes(x);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDoubleRes_min5_min10()
        {
            //arange
            double x = -5;
            double expected = -10;
            //act
            Project_for_UnitTests.Form1 c = new Project_for_UnitTests.Form1();
            double actual = c.DoubleRes(x);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDoubleRes_3_6()
        {
            //arange
            double x = 3;
            double expected = 6;
            //act
            Project_for_UnitTests.Form1 c = new Project_for_UnitTests.Form1();
            double actual = c.DoubleRes(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
