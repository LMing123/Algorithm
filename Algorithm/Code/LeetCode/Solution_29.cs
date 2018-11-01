using System;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 29. 两数相除
    /// </summary>
    public class Solution_29
    {

        public static int Fuck(int dividend, int divisor)
        {
            try
            {
                int fuck = 0;
                uint shit = (uint)(divisor < 0 ? 0 - divisor : divisor);
                uint holy_shit = (uint)(dividend < 0 ? 0 - dividend : dividend);

                int i = 31;
                checked
                {
                    while (i >= 0)
                    {
                        if ((holy_shit >> i) >= shit)
                        {
                            fuck += 1 << i;
                            holy_shit = holy_shit - (shit << i);
                        }
                        i = i - 1;
                    }

                }

                if (dividend < 0 && divisor < 0)
                {
                    checked
                    {
                        fuck = fuck > 0 ? fuck : 0 - fuck;
                    }
                }
                else if (dividend < 0 || divisor < 0)
                {
                    fuck = ~fuck + 1;
                }
                return fuck;
            }
            catch (OverflowException e)
            {
                return int.MaxValue;
            }
        }
        public static int old_Fuck(int dividend, int divisor)
        {

            try
            {
                int fuck = 0;
                int shit = divisor < 0 ? 0 - divisor : divisor;
                int holy_shit = dividend < 0 ? 0 - dividend : dividend;
                if (divisor == 1 || divisor == -1)
                {
                    fuck = dividend < 0 ? 0 - dividend : dividend;
                }
                else
                {
                    checked
                    {
                        for (int i = shit; i <= holy_shit; i = i + shit)
                        {
                            fuck++;
                        }
                    }
                }

                if (dividend < 0 && divisor < 0)
                {
                    checked
                    {
                        holy_shit = dividend < 0 ? 0 - dividend : dividend;
                    }
                }
                else if (dividend < 0 || divisor < 0)
                {
                    fuck = ~fuck + 1;
                }
                return fuck;
            }
            catch (OverflowException e)
            {
                return int.MaxValue;
            }


        }
    }
}
