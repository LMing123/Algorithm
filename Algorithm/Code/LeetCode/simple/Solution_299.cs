using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_299
    {
        public static string GetHint(string secret, string guess)
        {
            Dictionary<char, int> list = new Dictionary<char, int>();
            int positon = 0;
            int charac = 0;
            for (int i=0;i<secret.Length;i++)
            {
                if(list.ContainsKey(secret[i]))
                {
                    list[secret[i]]++;
                }
                else
                {
                    list.Add(secret[i], 1);
                }
                
            }
            for(int i=0;i<secret.Length;i++)
            {
                if (list.ContainsKey(guess[i])&&list[guess[i]]!=0)
                {
                    charac++;
                    list[guess[i]]--;
                }
                if (secret[i] == guess[i]) positon++;
            }
            return $"{positon}A{charac-positon}B";
        }
    }
}
