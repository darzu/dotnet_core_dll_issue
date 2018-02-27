using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace my_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(false, $"my_lib.MyLibClass.MyProp: {my_lib.MyLibClass.MyProp}");
        }
    }
}
