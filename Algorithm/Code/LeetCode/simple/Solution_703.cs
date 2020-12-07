using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_703
    {
        public class KthLargest
        {
            List<int> sets = null;
            int anchor = 0;
            public KthLargest(int k, int[] nums)
            {
                sets = new List<int>(k);
                anchor = k;
                int i = 0;
                while (i < k && i < nums.Length)
                {
                    sets.Add(nums[i]);
                    i++;
                }
                sets = sets.OrderByDescending(x => x).ToList();
                while (i < nums.Length)
                {
                    if (nums[i] > sets[^1])
                    {
                        sets[^1] = nums[i];
                        for (int j = sets.Count - 2; j >= 0 && nums[i] > sets[j]; j--)
                        {
                            sets[j + 1] = sets[j];
                            sets[j] = nums[i];
                        }
                    }
                    i++;
                }


            }

            public int Add(int val)
            {
                if (sets.Count < anchor)
                {
                    sets.Add(val);
                    if (sets.Count == anchor)
                        sets = sets.OrderByDescending(x => x).ToList();

                }
                else if (val > sets[^1])
                {
                    sets[^1] = val;
                    for (int j = sets.Count - 2; j >= 0 && val > sets[j]; j--)
                    {
                        sets[j + 1] = sets[j];
                        sets[j] = val;
                    }

                }
                return sets[^1];

            }
        }

    }
}
