using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateAttributes;

namespace UnitTestProject1
{
    [TestClass]
    public partial class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(false);
        }

        [DataTestMethod("10", 10)]
        [DataTestMethod("20",20)]
        [DataTestMethod("30", 30)]
        private void DataTest(string stringParam, int intParam)
        {
            Assert.AreEqual(intParam, Int32.Parse(stringParam));
        }

        [DataTestMethod("10", Result = 10, Message = "Test message")]
        [DataTestMethod("20", Result= 20)]
        [DataTestMethod("30", Result =30)]
        private int DataTestWithResult1(string stringParam)
        {
            return Int32.Parse(stringParam);
        }

        [DataTestMethod("10xxxx", Result = 10, Description = "Desc", ExpectedException = typeof(FormatException), Message = "ExceptionMessage")]
        [DataTestMethod("10", Result = 10, Description = "Desc", ExpectedException = typeof(Exception), Ignore = true, Priority = 3, TestName = "TestName", Timeout = 1000, WorkItem = 10)]
        private int DataTestWithResult2(string stringParam)
        {
            return Int32.Parse(stringParam);
        }

        [DataTestMethod("11", Result = 11, Priority = 3, Description = "XXX")]
        [DataTestMethod("12", Result = 12)]
        [Priority(10)]
        [WorkItem(100)]
        [Description("Test for \"{0}\" should return {1}")]
        private int DataTest(string stringParam)
        {
            return Int32.Parse(stringParam);
        }

        [DataTestMethod(@"123/123.123,__")]
        public void TextParsingTest(string param)
        {

        }

        [DataTestMethod]
        [DataRow("10", 10, DisplayName = "10 -> 10")]
        [DataRow("20", 20, DisplayName = "20 -> 20")]
        [DataRow("30", 30, DisplayName = "30 -> 30")]
        private void DataRowTest(string stringParam, int intParam)
        {
            Assert.AreEqual(intParam, Int32.Parse(stringParam));
        }
    }
}