using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeFunction;

namespace TimeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(15, Program.timeBetween(10, 55, 11, 10));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(6, Program.timeBetween(3,2,3,8));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(60, Program.timeBetween(1,0,2,0));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(45, Program.timeBetween(12, 20, 1, 5));
        }
    }
}
