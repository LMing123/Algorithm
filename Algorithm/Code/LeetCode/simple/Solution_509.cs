using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_509
    {
        public int Fib(int N)
        {
            int[] table=new int[N+1];
            table[0]=0;
            table[1]=1;
            for(int i=2;i<=N;i++)
            {
                table[i]=table[i-1]+table[i-2];
            }
            return table[N];
        }
        // public int Fib(int N)
        // {
        //     if(N==0) return 0;
        //     if(N==1) return 1;
        //     return Fib(N-1)+Fib(N-2);
        // }
    }
}
