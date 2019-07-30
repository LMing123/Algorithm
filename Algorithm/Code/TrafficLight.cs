using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code
{
    class TrafficLight
    {
        public static void Fuck()
        {
            int colorType = 1;
            int[,] shit ={
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
                    if (shit[i, j] == 0&&color[j]==0)
                    {
                        for(int k=0;k<color.Length;k++)
                        {
                            if (shit[j, k] == 1 && color[k] == colorType) flag = false;
                        }if (flag) color[j] = colorType;
                    }
                    
                }


                colorType++;
            }

            Console.WriteLine(colorType);

        }
    }
}
