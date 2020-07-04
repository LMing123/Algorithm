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
            
            int?[] vs = { 1, -2, -3, 1, 3, -2, null, -1 };
            //var ooo= Fuck(vs.ToList());
            // var list = Common.BuildList(new int[]{ 1, 2});
  var tree = Common.BulidTree(ref vs);
            var s = Solution_437.PathSum(tree, -1);
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
