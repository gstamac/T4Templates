using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateAttributes;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        private const string testDescription = "";//String.Format("Test for {0} should return {1}", "10", 10);

        [TestMethod]
        //[Description(testDescription)]
        public void TestMethod2()
        {
            //string literal = "String.Format(\"Test for \\\"{0}\\\" should return {1}\", \"10\", 10)";
            //string executed = ParseString(literal);

            string literal = "Test for \"{0}\" should return {1}";
            TestParameters = "\"10\", 10";
            string executed = FormatDescription(literal);

            Assert.AreEqual("Test for \"10\" should return 10", executed);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("\"test \\\"test\\\"\"", ToLiteral("test \"test\""));
        }

        string TestParameters = "";

        public string FormatDescription(string description)
        {
            var codeProvider = new Microsoft.CSharp.CSharpCodeProvider();
            var compilerParameters = new System.CodeDom.Compiler.CompilerParameters()
            {
                GenerateExecutable = false,
                GenerateInMemory = true
            };
            string formatString = String.Format("String.Format({0}, {1});", description, TestParameters);
            string fileContents = @"using System; namespace tmp { public static class tmpClass { public static string GetValue() { return " + formatString + " } } }";
            var results = codeProvider.CompileAssemblyFromSource(compilerParameters, fileContents);
            var method = results.CompiledAssembly.GetType("tmp.tmpClass").GetMethod("GetValue");
            return method.Invoke(null, null) as string;
        }

        private static string ToLiteral(string input)
        {
            using (var writer = new System.IO.StringWriter())
            {
                using (var provider = new Microsoft.CSharp.CSharpCodeProvider())
                {
                    provider.GenerateCodeFromExpression(new System.CodeDom.CodePrimitiveExpression(input), writer, null);
                    return writer.ToString();
                }
            }
        }

        public static string ParseString(string txt)
        {
            var codeProvider = new Microsoft.CSharp.CSharpCodeProvider();
            var compilerParameters = new System.CodeDom.Compiler.CompilerParameters()
            {
                GenerateExecutable = false,
                GenerateInMemory = true
            };
            string fileContents = @"
using System;

namespace tmp
{
    public static class tmpClass
    {
        public static string GetValue()
        {
             return " + txt + @";
        }
    }
}";
            var results = codeProvider.CompileAssemblyFromSource(compilerParameters, fileContents);
            var method = results.CompiledAssembly.GetType("tmp.tmpClass").GetMethod("GetValue");
            return method.Invoke(null, null) as string;
        }
    }


}

