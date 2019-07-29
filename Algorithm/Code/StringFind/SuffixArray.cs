using Algorithm.Code.StringFind;
namespace Algorithm.Code.StringFind
{
    public class SuffixArray
    {
        const int MAXSIZE = 999;
        int[] rank = new int[MAXSIZE];
        int[] SA = new int[MAXSIZE];
        int[] secendRank = new int[MAXSIZE];
        int[] charBucket = new int[MAXSIZE];
        int bucketSize = 26;
        string s;

        public SuffixArray(string s)
        {
            this.s = s;
        }
        public void Start()
        {
            for (int i = 1; i < s.Length + 1; i++)  //初始化
            {
                rank[i] = s.GetCharHash(i);
                secendRank[i] = i;
            }
            Sort();
            for (int p = 1, step = 1; p < s.Length; step += step,bucketSize=p)
            {
                p = 0;
                for (int i = s.Length - step + 1; i < s.Length + 1; i++) //获取不包含第step的字符串
                {
                    p++;
                    secendRank[p] = i;
                }

                for(int i=1;i<s.Length+1;i++)
                {
                    if(SA[i]>step)
                    {
                        p++;
                        secendRank[p] = SA[i] - step;
                    }
                }
                Sort();
                var tep = rank;
                rank = secendRank;
                secendRank = tep;
                rank[SA[1]] = 1;
                p = 1;
                for (int i = 2; i < s.Length + 1; i++) 
                {
                    if (secendRank[SA[i]] == secendRank[SA[i - 1]] && secendRank[SA[i] + step] == secendRank[SA[i - 1] + step])
                    {
                        rank[SA[i]] = p;
                    }
                    else
                    {
                        rank[SA[i]] = ++p;
                    }

                }

            }
        }
        public void Sort()
        {
            for (int i = 0; i < bucketSize; i++)
            {
                charBucket[i] = 0;
            }
            for (int i = 1; i < s.Length + 1; i++)
            {
                charBucket[rank[secendRank[i]]]++;
            }
            for (int i = 1; i < bucketSize + 1; i++)
            {
                charBucket[i] += charBucket[i - 1];
            }
            for (int i = s.Length; i>0; i--)
            {
                SA[charBucket[rank[secendRank[i]]]] = secendRank[i];
                charBucket[rank[secendRank[i]]]--;
            }
        }





    }
    public static class Shit
    {
        public static int GetCharHash(this string s, int i) => CharConvert(s[i - 1]);
        private static int CharConvert(char c) => (int)c - 'a'+1;
    }

}
