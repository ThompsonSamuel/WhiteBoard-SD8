using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsPrimeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isPrimeTest1()
        {
            Assert.IsFalse (Primes.PrimeNumber.IsPrime(6));
        }
        [TestMethod]
        public void isPrimeTest2()
        {
            Assert.IsFalse (Primes.PrimeNumber.IsPrime(20));
        }
        [TestMethod]
        public void isPrimeTest3()
        {
            Assert.IsTrue (Primes.PrimeNumber.IsPrime(7919));
        }
        [TestMethod]
        public void isPrimeTest4() {
            Assert.IsTrue(Primes.PrimeNumber.IsPrime(337));
        }
        [TestMethod]
        public void isPrimeTest5() {
            Assert.IsTrue(Primes.PrimeNumber.IsPrime(2));
        }
    }
}
