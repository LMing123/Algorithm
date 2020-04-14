using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_190
    {
        public static uint reverseBits(uint n)
        {
            uint result = 0;
            for(int i=31;n!=0;i--)
            {
                result |= (n & 1) << i;
                n = n >> 1;
            }
            return result;
        }
        public static uint reverseBits_1(uint n)
        {
            char[] list = new char[32];
            var i = Convert.ToString(n, 2).ToCharArray();
            var temp = new List<char>(i);
            var count = temp.Count;
            if (temp.Count != 32)
            {
                for (int o = 0; o < 32 - count; o++)
                {
                    temp.Insert(0, '0');
                }
            }
            temp.Reverse();
           var j=new string(temp.ToArray());

            return Convert.ToUInt32(j,2);
        }
    }
}
