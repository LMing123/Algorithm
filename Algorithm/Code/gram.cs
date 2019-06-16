using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class fuck
    {
        static void shit(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());//数量
            int m = int.Parse(Console.ReadLine().Trim());// 容量
            List<int[]> list = new List<int[]>();
            string line;
            while ( (line = System.Console.ReadLine()) != "")
            {//注意while处理多个case
                int[] tem = new int[2];
                string[] tokens = line.Split();
                for(int zz=0;zz<2;zz++)
                {
                    tem[zz] = int.Parse(tokens[zz]);
                }
                list.Add(tem);
            }
                int i, w;
                int W = n;
                int[,] totval = new int[5, W + 1];
                // 数组totval用来存贮最大的总价值

                //int[] best = new int[W + 1];

                // best 存贮的是当前价值最高的物品
                int Len = list.Count;
                for (w = 0; w <= W; w++)  //可选物品为0时，背包的价值。w为剩余背包容量，W为背包容量
                {
                    totval[0, w] = 0;
                }
                for (i = 1; i < Len; i++)//背包剩余容量为0时，背包的价值。
                {
                    totval[i, 0] = 0;
                }
                for (i = 1; i < Len; i++) //外循环
                {
                    for (w = 0; w <= W; w++) //内循环
                    {
                        if (w < list[i][0])//如果第i个物品重量大于背包剩余容量，则放不进去，说明第i个物品没在里面
                        {
                            totval[i, w] = totval[i - 1, w];
                        }
                        else //第i个物品可以放进去
                        {
                            if (totval[i - 1, w] < totval[i - 1, w - list[i][0]] + list[i][1])//如果第i个物品在背包里面的价值大于不在背包中的价值
                            {
                                totval[i, w] = totval[i - 1, w - list[i][0]] + list[i][1];//最大价值为totval[i,w]
                            }
                            else//第i物品在背包中的总价值小于除i以外可选物品的总价值
                            {
                                totval[i, w] = totval[i - 1, w];//最大价值为totval[i-1,w]
                            }
                        }
                    }
                }

                Console.WriteLine( totval[Len-1, W]);

                Console.ReadLine();


        }


    }
}
