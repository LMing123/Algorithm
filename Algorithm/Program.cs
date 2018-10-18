using Algorithm.code;
using Algorithm.Code.LeetCode;
using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        public static int fuck(int shit)
        {
            if (shit == 1 || shit == 0)
            {
                return 1;
            }
            return fuck(shit - 1) + fuck(shit - 2);
        }
        static void Main(string[] args)
        {


            string[] s = { "aa", "ab" };
            int[] nums ={ 49, 38, 65, 97, 76, 13, 27 };
            //int[] nums ={ 1, 2, 4, 8, 16, 32, 64, 128 };
            var shit = Solution.LetterCombinations("23");
            Console.WriteLine(shit);
            Console.ReadLine();


        }
    }
    //List<Good> goods = new List<Good> //（5，12），（4，3），（7，10），（2，3），（6，6）。
    //{
    //   new Good{weight=5,value=12},
    //   new Good{weight=4,value=3},
    //   new Good{weight=7,value=10},
    //   new Good{weight=2,value=3},
    //   new Good{weight=6,value=6},
    //};


    ////List<Good> goods = new List<Good> //（5，12），（4，3），（7，10），（2，3），（6，6）。
    ////{
    ////   new Good{weight=2,value=6},
    ////   new Good{weight=2,value=3},
    ////   new Good{weight=6,value=5},
    ////   new Good{weight=5,value=4},
    ////   new Good{weight=4,value=6},
    ////};

    //var shit = _0_1_Bag.Bag(15, goods);
}
