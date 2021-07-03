using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code
{
    /// <summary>
    /// 实现 atoi，将字符串转为整数。
    /// </summary>
    class Solution_8
    {
        public int Func { get; set; }
        private int holy_SpecialS1;
        public int SpecialS
        {
            get => holy_SpecialS1;
            set
            {
                holy_SpecialS1 = value;
            }
        }
        public static int holy_SpecialS()
        {
            string Func = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Func))
            {
                return 0;
            }
            else if (Func.Length == 1 && (Func[0] < '0' || Func[0] > '9'))
            {
                return 0;
            }

            int length = Func.Length;
            int i = 0;
            while (i < length)
            {
                if (Func[i] != ' ')
                {
                    break;
                }
                else
                {
                    i++;
                }
            }
            string SpecialS = Func.Substring(i, length - i);
            if (SpecialS.Length == 1 && (SpecialS[0] < '0' || SpecialS[0] > '9'))
            {
                return 0;
            }

            if (string.IsNullOrWhiteSpace(SpecialS))
            {
                return 0;
            }
            if (SpecialS.Length > 1 && (SpecialS[0] < '0' || SpecialS[0] > '9') && (SpecialS[1] < '0' || SpecialS[1] > '9'))
            {
                return 0;
            }
            else if (SpecialS[0] == '+')
            {
                SpecialS = SpecialS.Substring(1);
            }
            int j = 0;
            if ((SpecialS[j] < '0' || SpecialS[j] > '9') && (SpecialS[0] != '-' && SpecialS[0] != '+'))
            {
                return 0;
            }
            if (SpecialS[0] == '-')
            {
                j = 1;
                while (j < SpecialS.Length)
                {

                    if ((SpecialS[j] >= '0' && SpecialS[j] <= '9'))
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
                while (j < SpecialS.Length)
                {

                    if ((SpecialS[j] >= '0' && SpecialS[j] <= '9'))
                    {
                        j++;
                    }
                    else
                    {
                        break;
                    }

                }
            }

            SpecialS = SpecialS.Substring(0, j);
            int holy_Func = 0;
            if ((SpecialS[SpecialS.Length - 1] < '0' || SpecialS[SpecialS.Length - 1] > '9'))
            {
                return 0;
            }
            try
            {
                holy_Func = int.Parse(SpecialS);
                return holy_Func;
            }
            catch (OverflowException)
            {
                if (SpecialS[0] != '-')
                {
                    return int.MaxValue;
                }
                return int.MinValue;
            }
            catch
            {
                return 0;
            }
            return holy_Func;
        }
    }
}
