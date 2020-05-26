using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_278
    {
       
        public static int FirstBadVersion(int n,int k)
        {
           
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid,k))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;

                }
            }
            return left;
        }
       static bool IsBadVersion(int n,int k)
        {
            if (n < k) return false;
            else return true;
        }
    }
}
