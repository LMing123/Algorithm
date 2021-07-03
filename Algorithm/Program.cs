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
using Algorithm.Code.LeetCode.medium;
using Algorithm.Code.LeetCode.hard;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var g = new Solution_43();
          //  Solution_43.Sum("321", "4");
           // var result=g.CombinationSum(new int[] { 2, 3, 6, 7 },7);
          //  var result=g.Multiply("456", "123");
           // var result=g.Multiply( "123456789", "987654321");
            var result=g.Multiply("987654321", "123456789");
            Console.WriteLine(result);
            //var result=g.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });


            //var lists = new int[] { 2, 3, 1, 4, 5, 7, 6, 9, 8, 4, 22, 66, 44 };
            //QuickSort.Sort2(ref lists, 0, lists.Length - 1);

            //int[][] list = new int[5][] { new[] { 2, 3, 4 }, new[] { 5, 6, 7 }, new[] { 8, 9, 10 }, new[] { 11, 12, 13 }, new[] { 14, 15, 16 } };
            ////int[] list1 = new int[] { 2, 2, 3, 2, 4};
            //int[] list1 = new int[] { 3, 4, 2, 3 };
            //var s = new Solution_36();
            //char[][] SpecialS = new char[9][] {new char[]{'5','3','.','.','7','.','.','.','.'},
            //                               new char[]{'6','.','.','1','9','5','.','.','.'},
            //                               new char[]{'.','9','8','.','.','.','.','6','.'},
            //                               new char[]{'8','.','.','.','6','.','.','.','3'},
            //                               new char[]{'4','.','.','8','.','3','.','.','1'},
            //                               new char[]{'7','.','.','.','2','.','.','.','6'},
            //                               new char[]{'.','6','.','.','.','.','2','8','.'},
            //                               new char[]{'.','.','.','4','1','9','.','.','5'},
            //                               new char[]{'.','.','.','.','8','.','.','7','9'}};

            //char[][] SpecialS1 = { new char[9] { '.', '.', '5', '.', '.', '.', '.', '.', '6' }, new char[9] { '.', '.', '.', '.', '1', '4', '.', '.', '.' }, new char[9] { '.', '.', '.', '.', '.', '.', '.', '.', '.' }, new char[9] { '.', '.', '.', '.', '.', '9', '2', '.', '.' }, new char[9] { '5', '.', '.', '.', '.', '2', '.', '.', '.' }, new char[9] { '.', '.', '.', '.', '.', '.', '.', '3', '.' }, new char[9] { '.', '.', '.', '5', '4', '.', '.', '.', '.' }, new char[9] { '3', '.', '.', '.', '.', '.', '4', '2', '.' }, new char[9] { '.', '.', '.', '2', '7', '.', '6', '.', '.' } };

            //var Func = s.IsValidSudoku(SpecialS1);

            // var Func = s.ValidPalindrome("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga");
            //var lists3 = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } };
            // var lists2 = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 }};
            // var Func = s.FloodFill(lists2, 0,0,2);
        }


    }

    public class SpecialS
    {
        public string Func(string i, string j)
        {
            return string.Concat(this, i, j);
        }
    }
}
