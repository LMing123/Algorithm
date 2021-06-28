using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.hard
{
    public class Solution_42
    {
        public int Trap(int[] height)
        {
            if (height.Length == 0) return 0;
            int start = 0, end = height.Length - 1;
            if (end == start) return 0;

            int result = 0;
            while (start < end&& (height[start]==0|| height[end]==0))
            {
                if (height[start] == 0)
                    start++;
                if (height[end] == 0)
                    end--;
            }
            var max = 0;
            while (start < end)
            {
                var tem_max = Math.Min(height[start], height[end]);
                if(tem_max>max)
                {
                    result -= ((end - start - 1) * max );
                    max = tem_max;
                    result += (end - start - 1) * max;
                }

               if(height[start]<height[end])
                {
                    start++;
                    if (height[start] != 0&&start!=end)
                        result = result - Math.Min(height[start], max);
                }
                else
                {
                    end--;
                    if (height[end] != 0 && start != end)
                        result = result - Math.Min(height[end], max);
                }
                

            }
            return result;
        }
        public int Trap1(int[] height)
        {
            if (height.Length == 0) return 0;
            int start = 0, end = height.Length - 1;
            if (end == start) return 0;

            int result = 0;
            int level_l = 0;
            int level_r = 0;
            while (start < end)
            {
                if (height[start] < height[end])
                {
                    if (height[start] >= level_l)
                    {
                        level_l = height[start];
                    }
                    else
                    {
                        result += level_l - height[start];
                    }
                    start++;
                }
                else
                {
                    if (height[end] >= level_r)
                    {
                        level_r = height[end];
                    }
                    else
                    {
                        result += level_r - height[end];
                    }
                    end--;
                }
            }
            return result;
        }
    }
}
