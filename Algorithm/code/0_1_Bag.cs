using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.code
{
    public class Good
    {
       public int weight { get; set; }
      public  int value { get; set; }
    }
    public class _0_1_Bag
    {
        public static int[,] Bag(int weight,  List<Good> goods)
        {
            int nums = goods.Count;
            int[,] result = new int[nums+1, weight+1];

            for(int i=1;i<=nums;i++)
            {
                for(int m=1;m<=weight;m++)
                {
                    if(m<goods[i-1].weight)
                    {
                        result[i,m] = result[i - 1,m];
                    }
                    else
                    {
                        result[i, m] = result[i - 1,m - goods[i - 1].weight] + goods[i - 1].value > result[i - 1,m] ? result[i - 1,m - goods[i - 1].weight] + goods[i - 1].value : result[i - 1,m];
                    }
                }
            }

            return result;
        }
    }
}
