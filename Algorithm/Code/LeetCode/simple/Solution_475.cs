using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_475
    {
        // 要回过头来在看，2020年7月29日21:01:41 脑子有点乱
        public static int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(heaters);
            int result = int.MinValue;
            for (int i = 0; i < houses.Length; i++)
            {
                int left = 0;
                int right = heaters.Length-1;
                int mid = left + (right - left) / 2;
                while (left<right)
                {
                    if (heaters[mid] < houses[i]) left=mid+1;
                    else  right=mid;
                    mid = left + (right - left) / 2;
                }
                if(mid==0)
                {
                    int tem = Math.Abs(heaters[mid] - houses[i]);
                    result = Math.Max(result, tem);
                }
                else
                {
                    int tem = Math.Abs(heaters[mid] - houses[i]);
                    int tem2 = Math.Abs(heaters[mid-1] - houses[i]);
                    result = Math.Max(result, Math.Min( tem,tem2));
                }
              
            }
            return result;

        }
    }
}
