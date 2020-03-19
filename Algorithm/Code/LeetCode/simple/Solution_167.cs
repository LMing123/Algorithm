using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> list = new Dictionary<int, int>();
            for(int i=numbers.Length-1;i>=0;i--)
            {
                int value = target - numbers[i];
                if(list.ContainsKey(value))
                {
                   return new int[] { i + 1, list[value]  };
                }
                if(list.ContainsKey(numbers[i]))
                {
                    continue;
                }
                list.Add(numbers[i], i + 1);
            }
            return new int[] { };
        }
    }
}
