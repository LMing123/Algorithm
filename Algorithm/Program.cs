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
            var lists = new int[] { 2, 3, 1, 4, 5, 7, 6, 9, 8, 4, 22, 66, 44 };
            QuickSort.Sort2(ref lists, 0, lists.Length - 1);

            int[][] list = new int[5][] { new[] { 2, 3, 4 }, new[] { 5, 6, 7 }, new[] { 8, 9, 10 }, new[] { 11, 12, 13 }, new[] { 14, 15, 16 } };
            //int[] list1 = new int[] { 2, 2, 3, 2, 4};
            int[] list1 = new int[] { 3, 4, 2, 3 };
            var s = new Solution_733();
            // var fuck = s.ValidPalindrome("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga");
            var lists3 = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } };
            var lists2 = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 }};
            var fuck = s.FloodFill(lists2, 0,0,2);
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
