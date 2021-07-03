using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 30. 与所有单词相关联的字串
    /// 
    /// 
    /// </summary>
    ///             
   // string s = "pjzkrkevzztxductzzxmxsvwjkxpvukmfjywwetvfnujhweiybwvvsrfequzkhossmootkmyx
    //gjgfordrpapjuunmqnxxdrqrfgkrsjqbszgiqlcfnrpjlcwdrvbumtotzylshdvccdmsqoadfrpsvnwpizlwszr
    //tyclhgilklydbmfhuywotjmktnwrfvizvnmfvvqfiokkdprznnnjycttprkxpuykhmpchiksyucbmtabiqkisgb
    //hxngmhezrrqvayfsxauampdpxtafniiwfvdufhtwajrbkxtjzqjnfocdhekumttuqwovfjrgulhekcpjszyynadx
    //hnttgmnxkduqmmyhzfnjhducesctufqbumxbamalqudeibljgbspeotkgvddcwgxidaiqcvgwykhbysjzlzfbupk
    //qunuqtraxrlptivshhbihtsigtpipguhbhctcvubnhqipncyxfjebdnjyetnlnvmuxhzsdahkrscewabejifmxomb
    //iamxvauuitoltyymsarqcuuoezcbqpdaprxmsrickwpgwpsoplhugbikbkotzrtqkscekkgwjycfnvwfgdzogjzjv
    //pcvixnsqsxacfwndzvrwrycwxrcismdhqapoojegggkocyrdtkzmiekhxoppctytvphjynrhtcvxcobxbcjjivtfji
    //wmduhzjokkbctweqtigwfhzorjlkpuuliaipbtfldinyetoybvugevwvhhhweejogrghllsouipabfafcxnhukcbtmx
    //zshoyyufjhzadhrelweszbfgwpkzlwxkogyogutscvuhcllphshivnoteztpxsaoaacgxyaztuixhunrowzljqfqraho
    //sheukhahhbiaxqzfmmwcjxountkevsvpbzjnilwpoermxrtlfroqoclexxisrdhvfsindffslyekrzwzqkpeocilatftym
    //odgztjgybtyheqgcpwogdcjlnlesefgvimwbxcbzvaibspdjnrpqtyeilkcspknyylbwndvkffmzuriilxagyerjptbgeqge
    //biaqnvdubrtxibhvakcyotkfonmseszhczapxdlauexehhaireihxsplgdgmxfvaevrbadbwjbdrkfbbjjkgcztkcbwagtcnr
    //tqryuqixtzhaakjlurnumzyovawrcjiwabuwretmdamfkxrgqgcdgbrdbnugzecbgyxxdqmisaqcyjkqrntxqmdrczxbebemcbl
    //ftxplafnyoxqimkhcykwamvdsxjezkpgdpvopddptdfbprjustquhlazkjfluxrzopqdstulybnqvyknrchbphcarknnhhovweaqa
    //wdyxsqsqahkepluypwrzjegqtdoxfgzdkydeoxvrfhxusrujnmjzqrrlxglcmkiykldbiasnhrjbjekystzilrwkzhontwmehrfsrz
    //faqrbbxncphbzuuxeteshyrveamjsfiaharkcqxefghgceeixkdgkuboupxnwhnfigpkwnqdvzlydpidcljmflbccarbiegsmweklwn
    //gvygbqpescpeichmfidgsjmkvkofvkuehsmkkbocgejoiqcnafvuokelwuqsgkyoekaroptuvekfvmtxtqshcwsztkrzwrpabqrrhnlerxjojemcxel";
    //string[] words = { "dhvf", "sind", "ffsl", "yekr", "zwzq", "kpeo", "cila", "tfty", "modg", "ztjg", "ybty", "heqg", "cpwo", "gdcj", "lnle", "sefg", "vimw", "bxcb" };
    public class Solution_30
    {
        public static IList<int> FindSubstring(string s, string[] words)
        {
            List<int> result = new List<int>();

            if (s.Length == 0|| words.Length == 0)
                return result;
            Dictionary<string, int> ori_words = new Dictionary<string, int>();
            foreach(var tem in words)
            {
                if(ori_words.ContainsKey(tem))
                {
                    ori_words[tem] += 1;
                }
                else
                {
                    ori_words.Add(tem, 1);
                }
            }
            int word_length = words[0].Length;
            int length = words[0].Length*words.Length;

            for (int i = 0; i <= s.Length - length; i++)
            {
                string sub_s = s.Substring(i, length);
                Dictionary<string, int> count = new Dictionary<string, int>();
                int j = 0;
                while(j<=sub_s.Length-word_length)
                {
                    string word = sub_s.Substring(j, word_length);
                    if(ori_words.ContainsKey(word))
                    {
                        if(count.ContainsKey(word))
                        {
                            count[word] += 1;
                        }
                        else
                        {
                            count.Add(word, 1);
                        }
                        if(count[word]>ori_words[word])
                        {
                            break;
                        }
                        j = j + word_length;

                    }
                    else
                    {
                        break;
                    }
                }
                if(j== sub_s.Length)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static List<string> CombinationWords(List<string> words)
        {
            if (words.Count == 1)
                return words;
            List<string> result = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                var tep = words.Where((o, j) => j != i).ToList();
                var query = CombinationWords(tep);
                foreach (var word in query)
                {
                    result.Add(words[i] + word);
                }
            }
            return result;
        }
    }
}
