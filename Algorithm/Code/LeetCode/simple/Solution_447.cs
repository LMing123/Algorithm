using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_447
    {
        public static int NumberOfBoomerangs(int[][] points)
        {
            int result = 0;
            for (int i = 0; i < points.Length; i++)
            {
                Dictionary<int, int> countList = new Dictionary<int, int>();
                for (int j = 0; j < points.Length; j++)
                {
                    if (j == i) continue;
                    var tem = CalculateDistance(points[i], points[j]);
                    if (countList.ContainsKey(tem)) countList[tem]++;
                    else countList.Add(tem, 1);
                }
                foreach (var item in countList)
                {
                    if (item.Value >= 2) result = result + item.Value * (item.Value - 1);
                }
            }
            return result;
        }
        static int CalculateDistance(int[] i, int[] j)
        {
            return (i[0] - j[0]) * (i[0] - j[0]) + (i[1] - j[1]) * (i[1] - j[1]);
            // return Math.Abs(i[0] - j[0]) + Math.Abs(i[1] - j[1]);
        }


        /// too slow
        /*   public static int NumberOfBoomerangs(int[][] points)
           {
               int result = 0;
               for (int i = 0; i < points.Length; i++)
               {
                   result += GetCombination(ref points, new int[][] { points[i] }, i, i, 2);
               }
               return result;
           }

           static int GetCombination(ref int[][] points, int[][] lists, int skipIndex1, int skipIndex2, int level)
           {
               int result = 0;
               if (level == 1)
               {

                   for (int i = 0; i < points.Length; i++)
                   {
                       if (i == skipIndex1 || i == skipIndex2) continue;
                       if (CalculateDistance(lists[0], lists[1], points[i])) result++;
                   }
                   return result;
               }
               else
               {
                   for (int i = 0; i < points.Length; i++)
                   {
                       if (i == skipIndex1) continue;
                       result += GetCombination(ref points, new int[][] { lists[0], points[i] }, skipIndex1, i, level - 1);
                   }
               }
               return result;

           }
           static bool CalculateDistance(int[] i, int[] j, int[] k)
           {
               return (i[0] - j[0])* (i[0] - j[0] )+ (i[1] - j[1]) * (i[1] - j[1]) == (i[0] - k[0])* (i[0] - k[0]) + (i[1] - k[1])* (i[1] - k[1]);
           }*/

    }
}
