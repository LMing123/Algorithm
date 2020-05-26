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
            //int[] vs = { 7, 1, 5, 3, 6, 4 };
            //int[] vs = { 1,2,3};
            //var ooo= Fuck(vs.ToList());
            // var list = Common.BuildList(new int[]{ 1, 2});
            var result = Solution_278.FirstBadVersion(5, 4);
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
