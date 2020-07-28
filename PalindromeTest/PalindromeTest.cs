using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void PalindromeTest_Racecar()
        {
            Assert.AreEqual(true, Palindrome.isPalindrome("racecar"));
        }
        [TestMethod]
        public void PalindromeTest_Palindrom()
        {
            Assert.AreEqual(false, Palindrome.isPalindrome("Palindrom"));
        }
        [TestMethod]
        public void PalindromeTest_Gustavo()
        {
            Assert.AreEqual(false, Palindrome.isPalindrome("Gudavo"));
        }
        [TestMethod]
        public void PalindromeTest_Bob()
        {
            Assert.AreEqual(true, Palindrome.isPalindrome("Bob"));
        }
    }
}
