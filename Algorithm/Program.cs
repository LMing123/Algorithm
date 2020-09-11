using Algorithm.Code;
using Algorithm.Code.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using Algorithm.Code.LeetCode.simple;
using Algorithm.Code.StringFind;
using Algorithm.Code.Other;
using System.Threading;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] nums = new int[][]
            {
                new int[]{ 1,2,3},
                new int[]{4,5,6},
                new int[]{4,5,6},
                new int[]{4,5,6}
            };
            var i = nums.Length;
            var i2 = nums.SelectMany(x => x);

            var solution = new Solution_557();
            var s = solution.ReverseWords("Let's take LeetCode contest");
        }


    }

    public class Shit
    {
        public string Fuck(string i, string j)
        {
            return string.Concat(this, i, j);
        }
    }
}
