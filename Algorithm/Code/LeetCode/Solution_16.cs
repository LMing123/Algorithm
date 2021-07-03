using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code
{
    public class Solution_16
    {
        public static int ThreeSumClosest(int[] nums,int target)
        {
           // Array.Sort(nums);
            int head = 0;
            int x = nums.Length - 2;
            int dis = 9999;
            int best = 0;
            int[] bestNums = new int[3];
            while (head < x)
            {
                int i = head + 1;
                int j = x + 1;
                while(i<j)
                {
                    
                    while (i < j)
                    {
                        
                        int tem = nums[head] + nums[i] + nums[j];
                        if (Math.Abs(tem - target) < dis)
                        {
                            dis = Math.Abs(tem - target);
                            best = tem;
                            bestNums[0] = nums[head];
                            bestNums[1] = nums[i];
                            bestNums[2] = nums[j];
                        }
                        i++;
                    }
                    i = head + 1;
                    j--;
                }                
              
                head++;
            }
            return best;
        }
    }
}
