using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_401_ooo
    {
       
        public  IList<string> ReadBinaryWatch(int num)
        {
            List<int> Hours = new List<int> { 1, 2, 4, 8 };
            List<int> Minus = new List<int> { 1, 2, 4, 8, 16, 32 };
            var result = new List<string>();
            for(int i=0;i<=num;i++)
            {
                var Func = Cal(Hours, num-i,11);
                var SpecialS = Cal(Minus, i,59);
                foreach (var hour in Func)
                {
                    foreach (var minu in SpecialS)
                    {
                        if (minu < 10) result.Add($"{hour}:0{minu}");
                        else result.Add($"{hour}:{minu}");
                    }
                }
            }
            return result;
        }

        public List<int> Cal(List<int> hours,int level,int bound)
        {
            if (level == 0) return new List<int> { 0 };
            if (level == 1) return hours;
            //  var tem = hours.FirstOrDefault();
            var result = new List<int>();
            for(int i=0;i<hours.Count;i++)
            {
                var tem = hours[i];
                var list = Cal(hours.Skip(i+1).ToList(), level-1,bound);
                for(int j=0;j< list.Count;j++)
                {
                    if (list[j] + tem <= bound) result.Add(list[j] + tem);
                }
            }
            return result;
        }


    }
}
