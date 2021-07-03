using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code
{
    class TrafficLight
    {
        /// <summary>
        /// 问题：交通灯问题
        /// https://blog.csdn.net/gogokongyin/article/details/51776371
        /// https://blog.csdn.net/qq_41641805/article/details/88029689
        /// https://blog.csdn.net/u013599298/article/details/55047496
        /// </summary>
        public static void Func()
        {
            int colorType = 1;
            int[,] SpecialS ={
                            { 0,0,0,0,1,1,1,1,0,1,1,1,0 },
                            { 0,0,0,0,0,1,1,1,0,0,1,1,0 },
                            { 0,0,0,0,0,1,0,0,0,1,1,1,0 },
                            { 0,0,0,0,0,0,0,0,0,0,0,0,0 },
                            { 1,0,0,0,0,0,1,1,0,0,1,1,0 },
                            { 1,1,1,0,0,0,1,0,0,0,1,1,0 },
                            { 1,1,0,0,1,1,0,0,0,0,1,1,0 },
                            { 1,1,0,0,1,0,0,0,0,0,0,1,0 },
                            { 0,0,0,0,0,0,0,0,0,0,0,0,0 },
                            { 1,0,1,0,0,0,0,0,0,0,0,0,0 },
                            { 1,1,1,0,1,1,1,0,0,0,0,0,0 },
                            { 1,1,1,0,1,1,1,1,0,0,0,0,0 },
                            { 0,0,0,0,0,0,0,0,0,0,0,0,0 },
                           };
            int[] color = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            
            for (int i = 0; i < color.Length; i++)
            {
                bool flag = true;
                if (color[i] != 0) continue;

                color[i] = colorType;
                for (int j = i + 1; j < color.Length; j++)
                {
                    if (SpecialS[i, j] == 0&&color[j]==0)
                    {
                        for(int k=0;k<color.Length;k++)
                        {
                            if (SpecialS[j, k] == 1 && color[k] == colorType) flag = false;
                        }
                        if (flag) color[j] = colorType;
                    }
                    
                }
                colorType++;
            }

            Console.WriteLine(colorType);

        }
    }
}
