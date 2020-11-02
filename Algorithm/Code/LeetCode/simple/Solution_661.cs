using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_661
    {
        public int[][] ImageSmoother(int[][] M)
        {
            int[][] result= new int[M.Length][];

            for(int i=0;i<M.Length;i++)
            {
                result[i] = new int[M[i].Length];
                for(int j=0;j<M[i].Length;j++)
                {
                    result[i][j] = Helper(ref M, i, j);
                }
            }
            return result;

        }


        public int Helper(ref int[][] array,int starX,int starY)
        {
            int count = 0;
            int sum = 0;
            for(int i=starX-1<0?0:starX-1 ;i<= (starX + 1 > array.Length-1 ? array.Length-1 : starX + 1); i++)
            {
                for(int j = starY - 1 < 0 ? 0 : starY - 1; j <= (starY + 1 > array[i].Length-1 ? array[i].Length-1 : starY + 1); j++)
                {
                    sum += array[i][j];
                    count++;
                }
            }
            return sum / (count);
        }
    }
}
