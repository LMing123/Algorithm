using Algorithm.Code;
using Algorithm.Code.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using Algorithm.Code.LeetCode.simple;
using Algorithm.Code.StringFind;
using Algorithm.Code.Other;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] list = new int[5][] { new[] { 2, 3, 4 }, new[] { 5, 6, 7 }, new[] { 8, 9, 10 }, new[] { 11, 12, 13 }, new[] { 14, 15, 16 } };
            //int[] list1 = new int[] { 2, 2, 3, 2, 4};
            int[] list1 = new int[] { 3,4,2,3};
            var s = new Solution_665();
            var fuck = s.CheckPossibility(list1);
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
