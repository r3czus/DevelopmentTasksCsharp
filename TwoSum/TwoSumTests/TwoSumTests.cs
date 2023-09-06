using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TwoSum;

namespace TwoSumTests
{
    [TestClass]
    public class TwoSumTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution solution = new Solution();

            int[] nums = new[] {2, 7, 11, 15};
            int target = 9;
            int[]output = new int[] {0, 1};
            int[] answer=  solution.TwoSum(nums, target);

            for(int i = 0;i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], output[i]);
            }
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            Solution solution = new Solution();

            int[] nums = new[] { 3,2,4 };
            int target = 6;
            int[] output = new int[] { 1, 2 };
            int[] answer = solution.TwoSum(nums, target);

            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], output[i]);
            }

        }
        [TestMethod]
        public void TestMethod3()
        {
            Solution solution = new Solution();

            int[] nums = new[] { 3,3};
            int target = 6;
            int[] output = new int[] { 0, 1 };
            int[] answer = solution.TwoSum(nums, target);

            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], output[i]);
            }

        }
    }
}
