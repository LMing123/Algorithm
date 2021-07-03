using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode
{
    class Solution_18
    {
        public static IList<IList<int>> FourSum(int[] nums, int target)
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
                            int Func_m = nums[m];
                            m++;
                            while (m < length && Func_m == nums[m])
                            {
                                m++;
                            }
                        }
                        int f_k = nums[k];
                        k++;
                        while (k < length && nums[k] == f_k)
                        {
                            k++;
                        }
                    }
                    int f_j = nums[j];
                    j++;
                    while (j < length && nums[j] == f_j)
                    {
                        j++;
                    }
                }
                int f_i = nums[i];
                i++;
                while (i < length && nums[i] == f_i)
                {
                    i++;
                }
            }
            return (IList<IList<int>>)list;
        }
    }
}
