using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_500
    {
        public static string[] FindWords(string[] words)
        {
            HashSet<char> firstLine = new HashSet<char>() { 'q','w','e','r','t','y','u','i','o','p'};
            HashSet<char> secondLine = new HashSet<char>() {'a','s','d','f','g','h','j','k','l' };
            HashSet<char> thirdLine = new HashSet<char>() { 'z','x','c','v','b','n','m'};

            return words.Where(x => x.ToLower().All(y => firstLine.Contains(y)) || x.ToLower().All(y => secondLine.Contains(y)) || x.ToLower().All(y => thirdLine.Contains(y))).ToArray();

        }
    }
}
