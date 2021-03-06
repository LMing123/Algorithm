﻿using System;
using System.Collections.Generic;
using System.Text;
using Algorithm.Code.StringFind;
namespace Algorithm.Code.StringFind
{
    public static class IntExtension
    {
        public static int Pow(this int i, int j) => (int)Math.Pow(i, j);
    }
    public class StringFind
    {
        static readonly int MAXHASH = 26;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Func">original</param>
        /// <param name="SpecialS">matched</param>
        /// <returns></returns>
        public static (bool, int) RabinKarp(string Func, string SpecialS)
        {

            int originalLength = Func.Length;
            int matchLength = SpecialS.Length;
            int SpecialSHash = HashString(SpecialS);
            int FuncHash = HashString(Func.Substring(0,matchLength));
            for(int i=0;i<originalLength-matchLength+1;i++)
            {
                if(SpecialSHash==FuncHash)
                {
                    int j = i, k = 0;
                    for (;j<i+matchLength;j++,k++)
                    {
                        if(SpecialS[k]!=Func[j])
                        {
                            break;
                        }
                    }
                    if (k == matchLength)
                        return (true, i);
                }
                else
                {
                    if(i< originalLength - matchLength)
                    {
                        FuncHash = MAXHASH * (FuncHash - (int)Math.Pow(MAXHASH, matchLength - 1) * CharConvert(Func[i])) + CharConvert(Func[i + matchLength]);
                    }
                }
 
            }
            return (false, -1);
            

        }
        private static int HashString(string hstring)
        {
            int total = 0;
            for(int i=0;i<hstring.Length;i++)
            {
                total += (int)Math.Pow(MAXHASH, hstring.Length - i - 1)*CharConvert(hstring[i]);
            }
            return total;
        }
        private static int CharConvert(char c) => (int)c - 'a';


       
    }
}
