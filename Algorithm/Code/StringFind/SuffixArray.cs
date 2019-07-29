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


        public void Fuck(string s)
        {
            for (int i = 1; i < s.Length + 1; i++)  //初始化
            {
                charBucket[s.GetCharHash(i)]++;
                secendRank[i] = i;
            }
        }




       
    }
    public static class Shit
    {
        public static int GetCharHash(this string s, int i) => CharConvert(s[i - 1]);
        private static int CharConvert(char c) => (int)c - 'a';
    }

}
