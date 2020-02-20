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
            //string c = "34196372";
            //string d = "1963";
            //string a = "abcabaabcabac";
            //string b = "abaa";
            //Console.WriteLine(StringFind.RabinKarp(a,b).Item1);
            //Console.WriteLine(StringFind.RabinKarp(a,b).Item2);
            //var items = Solution_100.CreateDiffTree();
            //var shit = Solution_100.Fuck(items.q, items.p);
            // Console.WriteLine(shit);
            //SuffixArray suffix = new SuffixArray("abbaaaab");
            //suffix.Start();
            
            int?[] a = { 3, 9, 20, null, null, 15, 7 };

            int[] b = { -10, -3, 0, 5, 9 };


            DateTime dateTime = DateTime.Now;
            var tree = Solution_108.SortedArrayToBST1(b,0,b.Length-1);
            var i = (DateTime.Now - dateTime).TotalMilliseconds;

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
