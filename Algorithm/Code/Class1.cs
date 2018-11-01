using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code
{
    public class Model
    {
        public int inter { get; set; }
        public int fenzi { get; set; }
        public int fenmu { get; set; }
    }
    class Class1
    {
        public static int Fuck(string s)
        {
            string tem = s;
            int count = 0;
            for(int i=0;i+1<s.Length;i++)
            {
                if((s[i]=='L'&&s[i+1]=='R')|| (s[i] == 'R' && s[i + 1] == 'L'))
                {
                    continue;
                }
                count++;
                i++;
            }
            return count;
        }
        
        public static string Shit()
        {
            Model model_one = new Model();
            Model model_two = new Model();

            string first = Console.ReadLine();
            string fh = Console.ReadLine();
            string last = Console.ReadLine();

            var tem_first = first.Split(' ');
            var tem_last = last.Split(' ');
            if(tem_first.Length!=2)
            {
                if(tem_first[0].Contains('/'))
                {
                    model_one.inter = 0;
                    model_one.fenzi = int.Parse((tem_first[0].Split('/'))[0]);
                    model_one.fenmu = int.Parse((tem_first[0].Split('/'))[1]);
                }
                else
                {
                    model_one.inter = int.Parse(tem_first[0]);
                }
            }
            else
            {
                model_one.inter = int.Parse(tem_first[0]);
                model_one.fenzi = int.Parse(tem_first[1].Split('/')[0]);
                model_one.fenmu = int.Parse(tem_first[1].Split('/')[1]);
            }

            if (tem_last.Length != 2)
            {
                if (tem_last[0].Contains('/'))
                {
                    model_one.inter = 0;
                    model_one.fenzi = int.Parse((tem_last[0].Split('/'))[0]);
                    model_one.fenmu = int.Parse((tem_last[0].Split('/'))[1]);
                }
                else
                {
                    model_one.inter = int.Parse(tem_last[0]);
                }
            }
            else
            {
                model_one.inter = int.Parse(tem_last[0]);
                model_one.fenzi = int.Parse(tem_last[1].Split('/')[0]);
                model_one.fenmu = int.Parse(tem_last[1].Split('/')[1]);
            }
            string result="";
            switch(fh)
            {
                case "+":result= Plus(model_one,model_two);break;
                case "-": result = Sub(model_one,model_two); break;
                case "*": result = Mutil(model_one,model_two); break;
                case "/": result = Divi(model_one,model_two); break;
            }
            return result;
        }

        static string Plus(Model model_one,Model model_two)
        {
            return "";
        }
        static string Sub(Model model_one, Model model_two)
        {
            return "";
        }
        static string Mutil(Model model_one, Model model_two)
        {
            return "";
        }
        static string Divi(Model model_one, Model model_two)
        {
            return "";
        }


    }
}
