using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "K4(ON(SO3)2)2";
            string input1 = "Mg(OH)2";

            var tmp=fuckkk(input);

            var mp = tmp.Item1.OrderBy(x=>x.Key);

            foreach(var holy_shit in mp)
            {
                Console.Write($"{holy_shit.Key}{holy_shit.Value}");
            }
            Console.WriteLine();
             tmp = fuckkk(input1);

             mp = tmp.Item1.OrderBy(x => x.Key);
            foreach (var holy_shit in mp)
            {
                Console.Write($"{holy_shit.Key}{holy_shit.Value}");
            }

            //Console.WriteLine(input.Substring(1));
            Console.ReadLine();
        }

       public static (Dictionary<string,int>,int) fuckkk(string shit)
        {
            Dictionary<string, int> a_shit = new Dictionary<string, int>();
            int count_shit = 0;
            string tem = "";
            for (int i=0;i<shit.Length;i++)
            {
                if (shit[i] == '(')
                {
                    var z = fuckkk(shit.Substring(i + 1));
                    foreach (var s in z.Item1)
                    {
                        if (a_shit.ContainsKey(s.Key))
                        {
                            a_shit[s.Key] = a_shit[s.Key] + s.Value;
                        }
                        else
                        {
                            a_shit.Add(s.Key, s.Value);
                        }
                    }
                    i = i + z.Item2;
                    count_shit = i;
                    if (i > shit.Length - 1) return (a_shit, shit.Length);
                } 
                if (shit[i]==')')
                {
                    if(shit[i+1]!=null&&'0'<=shit[i+1]&&shit[i+1]<='9')
                    {
                        var k = a_shit.Keys.ToList();
                        foreach (var s in k)
                        {
                            a_shit[s] = a_shit[s] * int.Parse(shit[i + 1].ToString());
                        }
                        count_shit+=3;
                    }
                    return (a_shit, count_shit);
                }
                
                if('0' <= shit[i] && shit[i] <= '9')
                {
                    if(a_shit.ContainsKey(tem))
                    {
                        a_shit[tem] = a_shit[tem] + int.Parse(shit[i].ToString());
                    }
                    else
                    {
                        a_shit.Add(tem, int.Parse(shit[i].ToString()));
                    }
                    tem = "";
                    count_shit++;
                    continue;
                }
                if('a' <= shit[i] && shit[i] <= 'z')
                {
                    if('0' <= shit[i+1] && shit[i+1] <= '9')
                    {
                        tem += shit[i];
                        a_shit.Add(tem, int.Parse(shit[i + 1].ToString()));
                        tem = "";
                        i++;
                        count_shit+=2;
                    }
                    else
                    {
                        tem += shit[i];
                        a_shit.Add(tem, 1);
                        count_shit++;
                    }
                    continue;
                }
                if('A' <= shit[i] && shit[i ] <= 'Z')
                {
                    tem = shit[i].ToString();
                }
                if(('A' <= shit[i+1] && shit[i+1] <= 'Z')||(shit[i+1]=='(')|| (shit[i + 1] == ')'))
                {
                    a_shit.Add(tem, 1);
                    tem = "";
                }
                    count_shit++;


            }
            return (a_shit, shit.Length);
        }
    }
}
