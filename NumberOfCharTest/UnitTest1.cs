using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberOfChar;

namespace NumberOfCharTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDistinctElements()
        {
            int[] myTestNumbers = { 8, 6, 7, 5, 3, 0, 9 };
            Assert.AreEqual(7, DistinctElements.CountDistinct(myTestNumbers));

            myTestNumbers = new int[] { 9, 2, 1, 0, 1 };
            Assert.AreEqual(4, DistinctElements.CountDistinct(myTestNumbers));
        }
    }
}
