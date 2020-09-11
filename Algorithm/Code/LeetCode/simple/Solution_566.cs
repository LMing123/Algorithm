using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_566
    {

        public int[][] MatrixReshape(int[][] nums, int r, int c)
        {
            int l = nums.Length;
            if (l == 0) return nums;
            int h = nums[0].Length;
            if (l * h != r * c) return nums;
            int[][] result = new int[r][];
            int countFirst = 0;
            int countSecond = 0;
            result[0] = new int[c];
            for(int i=0;i<l;i++)
            {
                for(int j=0;j<h;j++)
                {
                    if(countSecond>=c)
                    {
                        countFirst++;
                        result[countFirst] = new int[c];
                        countSecond = 0;
                    }
                    result[countFirst][countSecond++] = nums[i][j];
                }
            }

            return result;
        }
        public int[][] MatrixReshape1(int[][] nums, int r, int c)
        {
           var lists= nums.SelectMany(x => x);
            if (r * c != lists.Count()) return nums;
            int[][] result = new int[r][];
            int sum = 0;
            for(int i=0;i<r;i++)
            {
                result[i] = new int[c];
                for(int j=0;j<c;j++)
                {
                    result[i][j] = lists.ElementAt(sum++);
                }

            }
            return result;
        }
    }
}
