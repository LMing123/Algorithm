using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_575
    {
        public int DistributeCandies(int[] candies)
        {
            //int count = candies.Length;
            //int catagory = candies.ToHashSet().Count;
            //int result = Math.Min(count / 2, catagory);
            //return result;



            int count = candies.Length;
            HashSet<int> vs = new HashSet<int>();
            for(int i=0;i<count;i++)
            {
                if (vs.Contains(candies[i])) continue;
                vs.Add(i);
            }

            //int catagory = candies.ToHashSet().Count;
            int result = Math.Min(count / 2, vs.Count);
            return result;
        }
    }
}
