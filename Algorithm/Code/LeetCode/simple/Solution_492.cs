using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_492
    {
        public static int[] ConstructRectangle(int area)
        {
            if (area == 0) return new int[] { 0, 0 };
            int[] result = new int[] {  area,1 };
            int min = area - 1; ;

            for(int i=2;i< Math.Sqrt(area);i++)
            {
                if (area % i != 0) continue;
                int j = area / i;
                if(Math.Abs( j-i)<min)
                {
                    min = Math.Abs(j-i);
                    result = new int[] { j,i};
                }               
            }
            return result;
        }
    }
}
