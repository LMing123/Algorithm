using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.code
{
    /// <summary>
    /// 实现 atoi，将字符串转为整数。
    /// </summary>
    class Solution_8
    {
        public int fuck { get; set; }
        private int holy_shit1;
        public int shit
        {
            get => holy_shit1;
            set
            {
                holy_shit1 = value;
            }
        }
        public static int holy_shit()
        {
            string fuck = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(fuck))
            {
                return 0;
            }
            else if (fuck.Length == 1 && (fuck[0] < '0' || fuck[0] > '9'))
            {
                return 0;
            }

            int length = fuck.Length;
            int i = 0;
            while (i < length)
            {
                if (fuck[i] != ' ')
                {
                    break;
                }
                else
                {
                    i++;
                }
            }
            string shit = fuck.Substring(i, length - i);
            if (shit.Length == 1 && (shit[0] < '0' || shit[0] > '9'))
            {
                return 0;
            }

            if (string.IsNullOrWhiteSpace(shit))
            {
                return 0;
            }
            if (shit.Length > 1 && (shit[0] < '0' || shit[0] > '9') && (shit[1] < '0' || shit[1] > '9'))
            {
                return 0;
            }
            else if (shit[0] == '+')
            {
                shit = shit.Substring(1);
            }
            int j = 0;
            if ((shit[j] < '0' || shit[j] > '9') && (shit[0] != '-' && shit[0] != '+'))
            {
                return 0;
            }
            if (shit[0] == '-')
            {
                j = 1;
                while (j < shit.Length)
                {

                    if ((shit[j] >= '0' && shit[j] <= '9'))
                    {
                        j++;
                    }
                    else
                    {
                        break;
                    }

                }
            }
            else
            {
                while (j < shit.Length)
                {

                    if ((shit[j] >= '0' && shit[j] <= '9'))
                    {
                        j++;
                    }
                    else
                    {
                        break;
                    }

                }
            }

            shit = shit.Substring(0, j);
            int holy_fuck = 0;
            if ((shit[shit.Length - 1] < '0' || shit[shit.Length - 1] > '9'))
            {
                return 0;
            }
            try
            {
                holy_fuck = int.Parse(shit);
                return holy_fuck;
            }
            catch (OverflowException)
            {
                if (shit[0] != '-')
                {
                    return int.MaxValue;
                }
                return int.MinValue;
            }
            catch
            {
                return 0;
            }
            return holy_fuck;
        }
    }
}
