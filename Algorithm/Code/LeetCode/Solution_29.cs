using System;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 29. 两数相除
    /// </summary>
    public class Solution_29
    {

        public static int Divide(int dividend, int divisor)
        {
            try
            {
                int result = 0;
                uint s = (uint)(divisor < 0 ? 0 - divisor : divisor);
                uint holy_s = (uint)(dividend < 0 ? 0 - dividend : dividend);

                int i = 31;
                checked
                {
                    while (i >= 0)
                    {
                        if ((holy_s >> i) >= s)
                        {
                            result += 1 << i;
                            holy_s = holy_s - (s << i);
                        }
                        i = i - 1;
                    }

                }

                if (dividend < 0 && divisor < 0)
                {
                    checked
                    {
                        result = result > 0 ? result : 0 - result;
                    }
                }
                else if (dividend < 0 || divisor < 0)
                {
                    result = ~result + 1;
                }
                return result;
            }
            catch (OverflowException e)
            {
                return int.MaxValue;
            }
        }
        public static int old_Divide(int dividend, int divisor)
        {

            try
            {
                int result = 0;
                int s = divisor < 0 ? 0 - divisor : divisor;
                int holy_s = dividend < 0 ? 0 - dividend : dividend;
                if (divisor == 1 || divisor == -1)
                {
                    result = dividend < 0 ? 0 - dividend : dividend;
                }
                else
                {
                    checked
                    {
                        for (int i = s; i <= holy_s; i = i + s)
                        {
                            result++;
                        }
                    }
                }

                if (dividend < 0 && divisor < 0)
                {
                    checked
                    {
                        holy_s = dividend < 0 ? 0 - dividend : dividend;
                    }
                }
                else if (dividend < 0 || divisor < 0)
                {
                    result = ~result + 1;
                }
                return result;
            }
            catch (OverflowException e)
            {
                return int.MaxValue;
            }


        }
    }
}
