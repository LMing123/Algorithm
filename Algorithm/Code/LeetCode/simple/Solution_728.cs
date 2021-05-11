using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_728
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> result = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (i < 10) result.Add(i);
                else
                {
                    var tem = i;
                    var flag = !(((tem % 10) == 0) || i % (tem % 10) != 0);
                    while (tem != 0 && flag)
                    {

                        if ((tem % 10) == 0 || i % (tem % 10) != 0)
                        {
                            flag &= false;
                        }
                        tem = tem / 10;


                    }
                    if (flag) result.Add(i);
                }
            }
            return result;
        }
    }
}
