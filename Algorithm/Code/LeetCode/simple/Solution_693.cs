using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_693
    {
        public bool HasAlternatingBits(int n)
        {
           
            int i = n & 1;
            n = n >> 1;
            while(n>0)
            {
                i = ~i&1;
                if ((n & 1) != i) return false;
                n = n >> 1;
            }
            return true;
        }
    }
}
