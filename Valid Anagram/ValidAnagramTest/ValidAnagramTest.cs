using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Valid_Anagram;

namespace ValidAnagramTest
{
    [TestClass]
    public class ValidAnagramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution solution = new Solution();
            string s = "anagram", t = "nagaram";

            Assert.IsTrue(solution.IsAnagram(s, t));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Solution solution = new Solution();
            string s = "rat", t = "cat";

            Assert.IsFalse(solution.IsAnagram(s, t));
        }
    }
}
