using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_679
    {
        public int FindShortestSubArray(int[] nums)
        {
            Dictionary<int, int> keyToTimes = new Dictionary<int, int>();
            Dictionary<int, int> keyToPosition = new Dictionary<int, int>();
            int times = 1;
            int result = 60000;

            for (int i = 0; i < nums.Length; i++)
            {
                int tem = nums[i];
                if (keyToTimes.ContainsKey(tem))
                {
                    keyToTimes[tem]++;
                    if(keyToTimes[tem]>times)
                    {
                        times = keyToTimes[tem];
                        result = i - keyToPosition[tem] + 1;
                    }else if(keyToTimes[tem] == times)
                    {
                        result = Math.Min(i - keyToPosition[tem] + 1, result);
                    }
                }
                else
                {
                    keyToTimes[tem] = 1;
                    keyToPosition[tem] = i;
                }
            }
        
            return result;
        }
        //public int FindShortestSubArray(int[] nums)
        //{
        //    Dictionary<int, int> keyToTimes = new Dictionary<int, int>();
        //    Dictionary<int, int[]> keyToPosition = new Dictionary<int, int[]>();
        //    int times = 1;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int tem = nums[i];
        //        if (keyToTimes.ContainsKey(tem))
        //        {
        //            keyToTimes[tem]++;
        //            keyToPosition[tem][1] = i;
        //        }
        //        else
        //        {
        //            keyToTimes[tem] = 1;
        //            keyToPosition[tem] = new int[2] { i, i };
        //        }
        //        if (keyToTimes[tem] > times) times = keyToTimes[tem];
        //    }
        //    int result = 60000;
        //    foreach (var item in keyToTimes)
        //    {
        //        if(item.Value==times)
        //        {
        //            if (result > keyToPosition[item.Key][1] - keyToPosition[item.Key][0] + 1)
        //                result = keyToPosition[item.Key][1] - keyToPosition[item.Key][0] + 1;
        //        }
        //    }
        //    return result;
        //}
    }
}
