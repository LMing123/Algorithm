using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_415
    {
        public string AddStrings(string num1, string num2)
        {
            var length = num1.Length >= num2.Length ? num1.Length + 1 : num2.Length + 1;
            var max = length;
            char[] list = new char[length];
            int num1_index = num1.Length - 1;
            int num2_index = num2.Length - 1;
            int add = 0;
            while (num1_index >= 0 || num2_index >= 0)
            {
                int tem1 = num1_index >= 0 ? num1[num1_index] - '0' : 0;
                int tem2 = num2_index >= 0 ? num2[num2_index] - '0' : 0;
                if (tem1 + tem2 + add >= 10)
                {
                    list[length - 1] = (char)('0' + tem1 + tem2 + add - 10);
                    add = 1;
                }
                else
                {
                    list[length - 1] = (char)('0' + tem1 + tem2 + add);

                    add = 0;
                }
                num1_index--;
                num2_index--;
                length--;
            }
            if (add != 0)
            {
                list[--length] = (char)('0' + add);
            }
            var tem = list.AsSpan(length, max - length);
            return new string(tem);
        }
    }
}
