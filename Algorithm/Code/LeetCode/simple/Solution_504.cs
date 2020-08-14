using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_504
    {
        public string ConvertToBase7(int num)
        {
            StringBuilder sb = new StringBuilder();
            int quotient = Math.Abs(num);
            if(quotient<7)
            {
                sb.Append(quotient);
            }
            else
            {
               
                while (quotient >= 7)
                {
                    int reminder = quotient % 7;
                    quotient = num / 7;
                    sb.Append(reminder);
                }
                sb.Append(quotient);
            }
            if (num < 0) sb.Append('-');
            return new string(sb.ToString().Reverse().ToArray());
            
        }
    }
}
