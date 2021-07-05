using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.medium
{
    class Solution_45
    {

        public int Jump1(int[] nums)
        {
            int max = 0;
            int end = 0;
            int step = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                max = Math.Max(max, nums[i]+i);
                if (end == i)
                {
                    end = max;
                    step++;
                }
            }
            return step;
        }

        public int Jump(int[] nums)
        {
            if (nums.Length == 1) return 0;
            int[] temStep = new int[nums.Length];
            Array.Fill(temStep, int.MaxValue);
            temStep[0] = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 0)
                {
                    temStep[i] = int.MaxValue;
                    continue;
                }
                for (int j = i + 1; j <= i + nums[i] && j < nums.Length; j++)
                {
                    temStep[j] = Math.Min(temStep[j], temStep[i] + 1);
                }
            }

            return temStep[temStep.Length - 1];
        }
    }
}
