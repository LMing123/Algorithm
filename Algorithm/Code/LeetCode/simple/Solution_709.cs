using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_709
    {
        public string ToLowerCase(string str)
        {
          return new string( str.Select(x => (char)((Int16)x | 0x20)).ToArray());
        }
    }
}
