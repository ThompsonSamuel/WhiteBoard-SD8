using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CirclesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleTest1()
        {
            Assert.AreEqual(Math.PI, Circles.Circle.Area(1.0));
        }
        [TestMethod]
        public void CircleTest2()
        {
            Assert.AreEqual(100*Math.PI, Circles.Circle.Area(10.0));
        }
    }
}
