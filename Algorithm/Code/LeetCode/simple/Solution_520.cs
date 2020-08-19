using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_520
    {
        public static bool DetectCapitalUse(string word)
        {
            if (word.Length == 0) return false;
            if (word.Length == 1) return true;
            bool canUpper = true;
            bool canLower = true;
            
            if (!char.IsUpper(word[0]))
            {
                canUpper = false;
            }
            else
            {
                if (char.IsLower(word[1]))
                {
                    canUpper = false;
                }
                else
                {
                    canLower = false;
                }
            }       

            for (int i = 1; i < word.Length; i++)
            {
                var w = word[i]; 
                if (canLower && char.IsUpper(w))
                    return false;
                else if (canUpper && char.IsLower(w))
                    return false;              
            }
            return true;
        }
    }
}
