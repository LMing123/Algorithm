using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_292
    {
        public static bool CanWinNim(int n)
        {
            /**
            *  题解：
            *     1.如果为4，则必输，可以推断，为8也必输，12也必输。 而其他情况则可以通过拿走的数量给对方留下4的倍数
            * 
            * */

            return n % 4 != 0;
        }
    }
}
