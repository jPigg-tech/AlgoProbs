using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProblems
{
    public class RunnningSumArray
    {
        public int[] RunningSum(params int[] nums)
        {
            int[] numsReturned = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

                if (i == 0)
                {
                    numsReturned[0] = nums[0];
                }
                if (i > 0)
                {
                    numsReturned[i] = numsReturned[i - 1] + nums[i];
                }
            }
            return numsReturned;
        }

        // Input: nums = [1,2,3,4]
        // Output: [1,3,6,10]
        // Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
    }
}
