using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_551
    {
        public bool CheckRecord(string s)
        {
            int ANum = 0;
            int LNum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'A':
                        {
                            LNum = 0;
                            ANum++;
                            if (ANum > 1) return false;
                            break;
                        }
                    case 'L':
                        {
                            LNum++;                            
                            break;
                        }
                    default:
                        LNum = 0;break;
                    
                }
                if (LNum > 2) return false;
            }
            return true;
        }
    }
}
