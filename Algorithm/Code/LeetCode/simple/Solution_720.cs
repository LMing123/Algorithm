using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{

    class Solution_720
    {

        public string LongestWord(string[] words)
        {
            var sets = words.ToHashSet();
            
            string results = "";
            int Max = 0;
            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                for (int j = 1; j <= words[i].Length - 1; j++)
                {
                    if (sets.Contains(words[i].Substring(0, j)))
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                        break;
                    }
                }
                if (count > Max)
                {
                    results = words[i];
                    Max = count;
                }
                else if (count == Max)
                {
                    int m = 0;
                    while (m < results.Length)
                    {
                        if (results[m] < words[i][m]) break;
                        if (results[m] > words[i][m])
                        {
                            results = words[i];
                            break;
                        }

                        m++;
                    }

                }

            }
            return results;
        }
    }
}
