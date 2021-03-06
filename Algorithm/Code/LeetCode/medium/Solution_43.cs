﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.medium
{
    class Solution_43
    {
        public string Multiply(string num1, string num2)
        {
            if (string.IsNullOrEmpty(num1) || string.IsNullOrEmpty(num2)) return "0";
            if (num1 == "0" || num2 == "0")
                return "0";
            int x = 0; //标志各个位
            string sum = "0";
            StringBuilder sb = new StringBuilder();

            for (int index_num1 = num1.Length - 1; index_num1 >= 0; index_num1--)
            {
                int i = num1[index_num1] - '0';
                int carryNum = 0;
                sb.Append('0', x);
                for (int index_num2 = num2.Length - 1; index_num2 >= 0; index_num2--)
                {
                    int j = num2[index_num2] - '0';
                    int tem = i * j + carryNum;
                    if (tem > 9)
                    {
                        sb.Append(tem % 10);
                        carryNum = tem / 10;
                    }
                    else
                    {
                        sb.Append(tem);
                        carryNum = 0;
                    }
                }
                if (carryNum != 0) sb.Append(carryNum);
                sum = Sum(sum, sb.ToString());
                sb.Clear();
                x++;
            }

            return new string(sum.Reverse().ToArray());
        }

        public static string Sum(string num1, string num2) // 参数都是逆序排的
        {
            if (num1 == "0" || num2 == "0")
                return num1 == "0" ? num2 : num1;
            int maxLength = Math.Max(num1.Length, num2.Length);
            if (num1.Length < maxLength)
                num1 = new StringBuilder(num1).Append('0', maxLength - num1.Length).ToString();
            if (num2.Length < maxLength)
                num2 = new StringBuilder(num2).Append('0', maxLength - num2.Length).ToString();
            var result = new StringBuilder(maxLength + 1);
            int carryNum = 0;
            for (int i = 0; i < maxLength; i++)
            {
                int single1 = num1[i] - '0';
                int single2 = num2[i] - '0';
                int tem = single1 + single2 + carryNum;
                if (tem > 9)
                {
                    result.Append(tem % 10);
                    carryNum = tem / 10;
                }
                else
                {
                    result.Append(tem);
                    carryNum = 0;
                }
            }
            if (carryNum != 0) result.Append(carryNum);

            return result.ToString();
        }

    }
}
