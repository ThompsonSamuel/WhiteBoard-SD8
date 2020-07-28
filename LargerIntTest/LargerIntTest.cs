using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LargerInt
{
    [TestClass]
    public class LargerIntTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("5 > 2", Program.intCompare(5, 2));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("9 > 7", Program.intCompare(7, 9));
        }
    }
}
