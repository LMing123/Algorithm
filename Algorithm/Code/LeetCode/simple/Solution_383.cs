using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> list = new Dictionary<char, int>();
            for(int i=0;i<magazine.Length;i++)
            {
                if(list.ContainsKey(magazine[i]))
                {
                    list[magazine[i]]++;
                }
                else
                {
                    list.Add(magazine[i], 1);
                }
            }

            for(int j=0;j<ransomNote.Length;j++)
            {
                if(list.ContainsKey(ransomNote[j]))
                {
                    if (list[ransomNote[j]] <= 0)
                    {
                        return false;
                    }
                    else
                    {
                        list[ransomNote[j]]--;
                    }
                }
                else
                {
                    return false;
                }               
            }
            return true;
        }
    }
}
