using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_733
    {
        bool[,] flags;
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            flags = new bool[image.Length, image[0].Length];
         //   flags[sr, sc] = true;
            MarkFill2(image, sr, sc,image[sr][sc],newColor);

            return image;
        }
        void MarkFill2(int[][] image, int sr, int sc, int oldColor, int newColor)
        {
            if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length || flags[sr, sc] || image[sr][sc] != oldColor) return;
            flags[sr, sc] = true;
            image[sr][sc] = newColor;

            MarkFill2(image, sr - 1, sc, oldColor, newColor);
            MarkFill2(image, sr + 1, sc, oldColor, newColor);
            MarkFill2(image, sr, sc - 1, oldColor, newColor);
            MarkFill2(image, sr, sc + 1, oldColor, newColor);
        }
        void MarkFill(ref int[][] image, int sr, int sc)
        {
            if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length) return;
            if (sr - 1 >= 0 && image[sr - 1][sc] == image[sr][sc] && flags[sr - 1, sc] == false)
            {
                flags[sr - 1, sc] = true;
                MarkFill(ref image, sr - 1, sc);
            }
            if (sr + 1 < image.Length && image[sr + 1][sc] == image[sr][sc] && flags[sr + 1, sc] == false)
            {
                flags[sr + 1, sc] = true;
                MarkFill(ref image, sr + 1, sc);
            }
            if (sc - 1 >= 0 && image[sr][sc - 1] == image[sr][sc] && flags[sr, sc - 1] == false)
            {
                flags[sr, sc - 1] = true;
                MarkFill(ref image, sr, sc - 1);
            }
            if (sc + 1 < image[0].Length && image[sr][sc + 1] == image[sr][sc] && flags[sr, sc + 1] == false)
            {
                flags[sr, sc + 1] = true;
                MarkFill(ref image, sr, sc + 1);
            }
        }
    }
}
