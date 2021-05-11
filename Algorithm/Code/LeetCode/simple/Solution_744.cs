using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_744
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            if (target >= letters.Last()) return letters.First();
            if (target < letters[0]) return letters[0];

            int begin = 0;
            int end = letters.Length - 1;
            int index = (end - begin) / 2 + begin;

            while (index != end && index != begin)
            {
                if (letters[index] > target) end = index;
                if (letters[index] <= target) begin = index;
                index = (end - begin) / 2 + begin;
            }
            if (letters[begin] <= target) return letters[begin + 1];
            else return letters[begin];


        }
    }
}
