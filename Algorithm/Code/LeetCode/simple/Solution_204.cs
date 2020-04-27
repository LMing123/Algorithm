﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_204
    {
        public int CountPrimes(int n)
        {
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if (isPrime(i)) count++;
            }
            return count;
        }
        private bool isPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
