using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AreaTest()
        {
            Assert.AreEqual(5.0, Geometry.Triangle.areaOfTriangle(2.0, 5.0));
        }
        [TestMethod]
        public void HypTest()
        {
            Assert.AreEqual(5.0, Geometry.Triangle.hypoteneuse(3.0, 4.0));
            Assert.AreEqual(5.0, Geometry.Triangle.hypoteneuse(4.0, 3.0));
        }
    }
}
