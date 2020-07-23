using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_463
    {
        public int IslandPerimeter(int[][] grid)
        {
            var result = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0) continue;
                    if (i - 1 < 0) result++;
                    if (i + 1 >= grid.Length) result++;
                    if (j - 1 < 0) result++;
                    if (j + 1 >= grid[i].Length) result++;
                    if (i - 1 >= 0 && grid[i - 1][j] == 0) result++;
                    if (i + 1 < grid.Length && grid[i + 1][j] == 0) result++;
                    if (j - 1 >= 0 && grid[i][j - 1] == 0) result++;
                    if (j + 1 < grid[i].Length && grid[i][j + 1] == 0) result++;
                }
            }
            return result;
        }
    }
}
