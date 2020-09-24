using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_605
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            bool canPlan = true;
            int sum = 0;
            for(int i=0;i<flowerbed.Length-1;i++)
            {
                if (flowerbed[i] == 1) canPlan = false;
                else if (canPlan && flowerbed[i] == 0 && flowerbed[i+1] == 0)
                {
                    canPlan = false;
                    sum++;
                }
                else if (flowerbed[i] == 0) canPlan = true;
            }
            if (flowerbed[flowerbed.Length - 1] == 0 && canPlan) sum++;
            return n <= sum ? true : false;
        }
    }
}
