using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode
{
    class Solution_18
    {
        public static IList<IList<int>> Fuck(int[] nums, int target)
        {
            Array.Sort(nums);
            int length = nums.Length;
            List<IList<int>> list = new List<IList<int>>();
            for (int i = 0; i < length;)
            {
                for (int j = i + 1; j < length;)
                {
                    for (int k = j + 1; k < length;)
                    {
                        for (int m = k + 1; m < length;)
                        {
                            if (nums[i] + nums[j] + nums[k] + nums[m] == target)
                            {
                                List<int> tem = new List<int>()
                                {
                                    nums[i],nums[j],nums[k],nums[m]
                                };
                                list.Add(tem);
                            }
                            int fuck_m = nums[m];
                            m++;
                            while (m < length && fuck_m == nums[m])
                            {
                                m++;
                            }
                        }
                        int fuck_k = nums[k];
                        k++;
                        while (k < length && nums[k] == fuck_k)
                        {
                            k++;
                        }
                    }
                    int fuck_j = nums[j];
                    j++;
                    while (j < length && nums[j] == fuck_j)
                    {
                        j++;
                    }
                }
                int fuck_i = nums[i];
                i++;
                while (i < length && nums[i] == fuck_i)
                {
                    i++;
                }
            }
            return (IList<IList<int>>)list;
        }
    }
}
