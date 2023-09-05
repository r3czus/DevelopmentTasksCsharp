using ContainsDuplicate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContainsDuplicateTest
{
    [TestClass]
    public class ContainsDuplicateTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution soution = new Solution();
            int[] nums= new int[] { 1,2,3,1 };
            bool result= soution.ContainsDuplicate(nums);

            Assert.IsTrue(result);
            //spodziwany output ture;

        }
        [TestMethod]
        public void TestMethod2()
        {
            Solution soution = new Solution();
            int[] nums = new int[] { 1, 2, 3, 4 };
            bool result = soution.ContainsDuplicate(nums);

            Assert.IsFalse(result);
            //spodziewany output false;
        } 
        [TestMethod]
            public void TestMethod3()
            {
                Solution soution = new Solution();
                int[] nums = new int[] {1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
                bool result = soution.ContainsDuplicate(nums);

                Assert.IsTrue(result);
               //spodziwany output true;
            }
    }
}
