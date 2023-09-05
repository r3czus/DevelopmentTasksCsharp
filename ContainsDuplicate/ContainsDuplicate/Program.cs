using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        }


    }
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {

            Array.Sort(nums);
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                    return true;
            }
            return false;
        }





    }

}
