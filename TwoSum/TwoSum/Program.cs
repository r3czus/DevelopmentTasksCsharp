using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

            //You may assume that each input would have exactly one solution, and you may not use the same element twice.

            //You can return the answer in any order.
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            int[] output = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target == (nums[i] + nums[j]))
                    {
                        output[0] = i;
                        output[1] = j;
                        break;
                    }
                }
            }
            return output;
        }

            
        }

            


            



        }
    }
}

