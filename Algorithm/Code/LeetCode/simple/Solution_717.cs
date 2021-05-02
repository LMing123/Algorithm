using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_717
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            int i = 0;
            bool flag = false;
            while(i<bits.Length)
            {
                if (bits[i] == 1)
                {
                    i += 2;
                    flag = false;
                }
                else
                {
                    i++;
                    flag = true;
                }
            }
            return flag;
        }
    }
}
