using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_405
    {
        public string ToHex(int num)
        {
            char[] digitals = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', };
            if (num == 0) return "0";
            StringBuilder sb = new StringBuilder();
            if(num>0)
            {
                while(num>0)
                {
                   var digital= num & 0b1111;
                    sb.Insert(0, digitals[digital]);
                    num >>= 4;
                }
            }
            else
            {
                int times = 8;
                while (times > 0)
                {
                    var digital = num & 0b1111;
                    sb.Insert(0, digitals[digital]);
                    num >>= 4;
                }
            }
            return sb.ToString();
        }
    }
}
