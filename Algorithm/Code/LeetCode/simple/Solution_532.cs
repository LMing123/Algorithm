using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_532
    {
        public static int FindPairs(int[] nums, int k)
        {
            if (k < 0) return 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    dic[nums[i]]++;
                else
                {
                    dic.Add(nums[i], 1);
                    list.Add(nums[i]);
                }
            }
            var result = 0;
            if (k == 0) return dic.Count(x => x.Value > 1);
            foreach (var item in dic)
            {
                if (dic.ContainsKey(item.Key + k)) result++;
            }
            return result;
            //if (k < 0) return 0;
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //List<int> list = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (dic.ContainsKey(nums[i]))
            //        dic[nums[i]]++;
            //    else
            //    {
            //        dic.Add(nums[i], 1);
            //        list.Add(nums[i]);
            //    }
            //}
            //var result = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    var num = list[i];
            //    int expNum = num + k;
            //    if (num == expNum)
            //    {
            //        if (dic[num] > 1)
            //        {
            //            result++;
            //            dic[num] -= 2;
            //        }
            //    }
            //    else if (dic.ContainsKey(expNum) && dic[expNum] > 0)
            //    {
            //        result++;
            //        dic[expNum]--;
            //    }
            //}
            //return result;



        }
    }
}
