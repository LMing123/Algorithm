using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_682
    {
        public int CalPoints(string[] ops)
        {
            List<int> scroes = new List<int>();
            for (int i = 0; i < ops.Length; i++)
            {
                if (int.TryParse(ops[i], out int result))
                {
                    scroes.Add(result);
                    continue;
                }

                switch (ops[i])
                {
                    case "D":
                        {
                            scroes.Add(scroes[^1] * 2);
                            break;
                        }
                    case "C": 
                        {
                            scroes.RemoveAt(scroes.Count - 1);
                            break; 
                        }
                    case "+":
                        {
                            scroes.Add(scroes[^1] + scroes[^2]);
                            break;
                        }
                }

            }

            return scroes.Sum();
        }
    }
}
