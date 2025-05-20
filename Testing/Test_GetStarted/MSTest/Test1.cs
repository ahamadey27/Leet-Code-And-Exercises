using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace MSTest
{
    [TestClass]
    public sealed class Test1
    {
        private const string Expected = "Testing!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Test_GetStarted.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
