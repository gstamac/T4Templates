using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("AddDataMsTests.tt", "")]
	[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	partial class UnitTest1
	{
		// DataTestMethod("10", 10)
		[TestMethod]
		[Description("DataTest(\"10\", 10)")]
		public void DataTest__10___10()
		{
			DataTest("10", 10);
		}
		// DataTestMethod("20",20)
		[TestMethod]
		[Description("DataTest(\"20\", 20)")]
		public void DataTest__20___20()
		{
			DataTest("20", 20);
		}
		// DataTestMethod("30", 30)
		[TestMethod]
		[Description("DataTest(\"30\", 30)")]
		public void DataTest__30___30()
		{
			DataTest("30", 30);
		}
		// DataTestMethod("10", Result = 10, Message = "Test message")
		[TestMethod]
		[Description("DataTestWithResult1(\"10\") == 10")]
		public void DataTestWithResult1__10___10()
		{
			Assert.AreEqual(10, DataTestWithResult1("10"), "Test message");
		}
		// DataTestMethod("20", Result= 20)
		[TestMethod]
		[Description("DataTestWithResult1(\"20\") == 20")]
		public void DataTestWithResult1__20___20()
		{
			Assert.AreEqual(20, DataTestWithResult1("20"));
		}
		// DataTestMethod("30", Result =30)
		[TestMethod]
		[Description("DataTestWithResult1(\"30\") == 30")]
		public void DataTestWithResult1__30___30()
		{
			Assert.AreEqual(30, DataTestWithResult1("30"));
		}
		// DataTestMethod("10xxxx", Result = 10, Description = "Desc", ExpectedException = typeof(FormatException), Message = "ExceptionMessage")
		[TestMethod]
		[Description("Desc")]
		[ExpectedException(typeof(FormatException), "ExceptionMessage")]
		public void DataTestWithResult2__10xxxx___10()
		{
			Assert.AreEqual(10, DataTestWithResult2("10xxxx"), "ExceptionMessage");
		}
		// DataTestMethod("10", Result = 10, Description = "Desc", ExpectedException = typeof(Exception), Ignore = true, Priority = 3, TestName = "TestName", Timeout = 1000, WorkItem = 10)
		[TestMethod]
		[Ignore]
		[Description("Desc")]
		[Priority(3)]
		[Timeout(1000)]
		[WorkItem(10)]
		[ExpectedException(typeof(Exception))]
		public void TestName()
		{
			Assert.AreEqual(10, DataTestWithResult2("10"));
		}
		// DataTestMethod("11", Result = 11, Priority = 3, Description = "XXX")
		[TestMethod]
		[Description("XXX")]
		[Priority(3)]
		[WorkItem(100)]
		public void DataTest__11___11()
		{
			Assert.AreEqual(11, DataTest("11"));
		}
		// DataTestMethod("12", Result = 12)
		[TestMethod]
		[Description("Test for \"12\" should return 12")]
		[Priority(10)]
		[WorkItem(100)]
		public void DataTest__12___12()
		{
			Assert.AreEqual(12, DataTest("12"));
		}
		// DataTestMethod(@"123/123.123,__")
		[TestMethod]
		[Description("TextParsingTest(@\"123/123.123,__\")")]
		public void TextParsingTest___123_123_123____()
		{
			TextParsingTest(@"123/123.123,__");
		}
		// DataRow("10", 10, DisplayName = "10 -> 10")
		[TestMethod]
		[Description("10 -> 10")]
		public void DataRowTest__10___10()
		{
			DataRowTest("10", 10);
		}
		// DataRow("20", 20, DisplayName = "20 -> 20")
		[TestMethod]
		[Description("20 -> 20")]
		public void DataRowTest__20___20()
		{
			DataRowTest("20", 20);
		}
		// DataRow("30", 30, DisplayName = "30 -> 30")
		[TestMethod]
		[Description("30 -> 30")]
		public void DataRowTest__30___30()
		{
			DataRowTest("30", 30);
		}
	}
}
