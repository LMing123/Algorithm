using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode
{
     public partial class Solution
    {
        /// <summary>
        /// 17. 电话号码的字母组合
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            if(digits.Length==0)
            {
                return result;
            }

            Dictionary<string, string[]> keyValuePairs = new Dictionary<string, string[]>()
            {
               { "2",new string[]{ "a","b","c"} } ,
               { "3",new string[]{ "d","e","f"} } ,
               { "4",new string[]{ "g","h","i"} } ,
               { "5",new string[]{ "j","k","l"} } ,
               { "6",new string[]{ "m","n","o"} } ,
               { "7",new string[]{ "p","q","r","s"} } ,
               { "8",new string[]{ "t","u","v"} } ,
               { "9",new string[]{ "w","x","y","z"} } ,
            };
            string[] nums = new string[digits.Length];
            for(int i=0;i<digits.Length;i++)
            {
                nums[i] = digits[i].ToString();
            }

            List<string[]> list = new List<string[]>();
            foreach(var i in nums)
            {
                list.Add(keyValuePairs[i]);
            }

            foreach(var tem in list[0])
            {
                result.Add(tem);
            }
            
            for(int j=1;j<list.Count;j++)
            {
                List<string> temp = new List<string>();
                for(int k=0;k<result.Count;k++)
                {
                    for(int m=0;m<list[j].Length;m++)
                    {
                        temp.Add(result[k] + list[j][m]);
                    }
                }
                result = temp;

            }
            return result;
        }
    }
}
