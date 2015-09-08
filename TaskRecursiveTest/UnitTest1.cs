using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskRecursive;

namespace TaskRecursiveTest {
    [TestClass]
    public class TaskRecursiveTest {
        [TestMethod]
        public void TestMethod1() {
            ScanWebUsingTask sw = new ScanWebUsingTask();
            var aw = sw.Scan("https://msdn.microsoft.com/en-us/default.aspx", 1);
            aw.Wait();

        }
    }
}
