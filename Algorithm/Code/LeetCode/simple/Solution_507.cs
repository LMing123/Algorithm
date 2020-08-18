using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_507
    {
        public bool CheckPerfectNumber(int num)
        {
            int sum = 1;
            for(int i=2;i*i<=num;i++)
            {
                if(num%i==0)
                {
                    sum += i;
                        sum += num / i;
                }
            }
            return sum == num;
        }
    }
}
