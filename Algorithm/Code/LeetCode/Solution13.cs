namespace Algorithm.Code
{
    /// <summary>
    /// /13. 罗马数字转整数
    /// </summary>
    public class Solution13
    {
        public static int Func(string s)
        {
            int length = s.Length;
            int SpecialS = 0;
            for (int i = 0; i < length; i++)
            {
                if (s[i] == 'M')
                {
                    SpecialS += 1000;
                }
                else if (s[i] == 'D')
                {
                    SpecialS += 500;
                }
                else if (s[i] == 'C')
                {
                    if (s[i] == 'C' && (i + 1 <= length - 1) && s[i + 1] == 'M')
                    {
                        SpecialS += 900;
                        i = i + 1;
                    }
                    else if (s[i] == 'C' && (i + 1 <=length - 1) && s[i + 1] == 'D')
                    {
                        SpecialS += 400;
                        i++;
                    }
                    else
                    {
                        SpecialS += 100;
                    }
                }
                else if (s[i] == 'L')
                {
                    SpecialS += 50;
                }
                else if (s[i] == 'X')
                {
                    if ((i + 1 <= length - 1) && s[i + 1] == 'C')
                    {
                        SpecialS += 90;
                        i = i + 1;
                    }
                    else if ((i + 1 <= length - 1) && s[i + 1] == 'L')
                    {
                        SpecialS += 40;
                        i++;
                    }
                    else
                    {
                        SpecialS += 10;
                    }
                }
                else if (s[i] == 'V')
                {
                    SpecialS += 5;
                }
                else
                {
                    if ((i + 1 <= length - 1) && s[i + 1] == 'X')
                    {
                        SpecialS += 9;
                        i = i + 1;
                    }
                    else if ((i + 1 <= length - 1) && s[i + 1] == 'V')
                    {
                        SpecialS += 4;
                        i++;
                    }
                    else
                    {
                        SpecialS += 1;
                    }
                }
            }
            return SpecialS;
        }
            
        }
}
