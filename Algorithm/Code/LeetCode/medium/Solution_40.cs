using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.medium
{
    class Solution_40
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);

            return Temp(ref candidates, target);

           

        }

        private List<IList<int>> Temp(ref int[] sets, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (sets.Length < 1) return result;
            var min = sets[0];
            if (target < min) return result;
            int anchor = -1;
            for (int i = 0; i < sets.Length; i++)
            {
                if (anchor != -1 && anchor == sets[i]) continue ;
                IList<int> tem = new List<int>();
                if (target - sets[i] == 0)
                {
                    tem.Add(sets[i]);
                    result.Add(tem);
                    continue;
                }
                if (target > sets[i])
                {
                    var tem_sets = sets[(i+1)..];
                    var values = Temp(ref tem_sets, target - sets[i]);
                    if(values==null) continue;
                    foreach (var item in values)
                    {
                        if (item.Count > 0)
                        {
                            item.Add(sets[i]);
                            result.Add(item);
                        }
                    }
                }
            }

            return result;
        }
    }
}
