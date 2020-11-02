using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_657
    {
        public bool JudgeCircle(string moves)
        {
            int horizontal = 0;
            int vertical = 0;

            for(int i=0;i<moves.Length;i++)
            {
                
                switch (moves[i])
                {
                    case 'U':vertical++;break;
                    case 'D':vertical--;break;
                    case 'L': horizontal--;break;
                    case 'R': horizontal++;break;
                    default:
                        break;
                }
            }
            return horizontal ==0&&vertical == 0 ? true : false;

        }
    }
}
