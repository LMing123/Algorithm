using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Algorithm.Code.LeetCode.FUCK
{
    public class Solution_443
    {
        public static int Compress(char[] chars)
        {
            int length = chars.Length;
            if (length <= 0) return 0;

            char word = chars[0];
            int last_postion= 0;
            int index = 1;
            int count = 1;
            for (int i = 1; i < length; i++)
            {
                if (chars[i] == word)
                {
                    count++;
                    last_postion = i;
                }
                else
                {
                    word = chars[i];
                    if (count != 1)
                    {
                        var tem = count.ToString();
                        for (int j = 0; j < tem.Length; j++)
                        {
                            chars[index] = tem[j];
                            index++;
                        }
                        if(index<= last_postion)
                        {
                            int position = index;
                            for (int k = i; k < length ; k++)
                            {
                                chars[position] = chars[k ];
                                position++;
                            }
                            length = length - count + 1 + tem.Length;
                            i = index;
                            index++;
                        }
                        
                        count = 1;

                    }

                    index = i + 1;
                }
            }
            if (count != 1)
            {
                var tem = count.ToString();
                for (int j = 0; j < tem.Length; j++)
                {
                    chars[index] = tem[j];
                    index++;
                }
            }

            return index;
        }
    }
}
