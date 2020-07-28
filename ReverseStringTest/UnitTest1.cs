using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseStringTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            Assert.AreEqual("elppA", ReverseString.Program.ReverseString("Apple"));
        }
    }
}
