using Algorithm.Code;
using Algorithm.Code.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using Algorithm.Code.LeetCode.simple;
using Algorithm.Code.StringFind;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = "34196372";
            string d = "1963";
            string a = "abcabaabcabac";
            string b = "abaa";
            Console.WriteLine(StringFind.RabinKarp(a,b).Item1);
            Console.WriteLine(StringFind.RabinKarp(a,b).Item2);
            //var items = Solution_100.CreateDiffTree();
            //var shit = Solution_100.Fuck(items.q, items.p);
           // Console.WriteLine(shit);

            Console.ReadLine();


        }
    }
}
