namespace Algorithm.code
{
    /// <summary>
    /// /13. 罗马数字转整数
    /// </summary>
    public class Solution13
    {
        public static int fuck(string s)
        {
            int length = s.Length;
            int shit = 0;
            for (int i = 0; i < length; i++)
            {
                if (s[i] == 'M')
                {
                    shit += 1000;
                }
                else if (s[i] == 'D')
                {
                    shit += 500;
                }
                else if (s[i] == 'C')
                {
                    if (s[i] == 'C' && (i + 1 <= length - 1) && s[i + 1] == 'M')
                    {
                        shit += 900;
                        i = i + 1;
                    }
                    else if (s[i] == 'C' && (i + 1 <=length - 1) && s[i + 1] == 'D')
                    {
                        shit += 400;
                        i++;
                    }
                    else
                    {
                        shit += 100;
                    }
                }
                else if (s[i] == 'L')
                {
                    shit += 50;
                }
                else if (s[i] == 'X')
                {
                    if ((i + 1 <= length - 1) && s[i + 1] == 'C')
                    {
                        shit += 90;
                        i = i + 1;
                    }
                    else if ((i + 1 <= length - 1) && s[i + 1] == 'L')
                    {
                        shit += 40;
                        i++;
                    }
                    else
                    {
                        shit += 10;
                    }
                }
                else if (s[i] == 'V')
                {
                    shit += 5;
                }
                else
                {
                    if ((i + 1 <= length - 1) && s[i + 1] == 'X')
                    {
                        shit += 9;
                        i = i + 1;
                    }
                    else if ((i + 1 <= length - 1) && s[i + 1] == 'V')
                    {
                        shit += 4;
                        i++;
                    }
                    else
                    {
                        shit += 1;
                    }
                }
            }
            return shit;
        }
            
        }
}
