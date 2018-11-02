using Algorithm.Code;
using Algorithm.Code.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
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

            List<List<int>> list = new List<List<int>>()
           {
               new List<int>{ 1,2,3,4,5},
               new List<int>{ 1,2,3,4,5},

           };

            //  var result = RecursionArrange.Fuck(s);
            //string s = "barfoothefoobarman";
            // string[] words = { "foo", "bar" };  
            //string s = "wordgoodgoodgoodbestword";
            //string[] words = { "word", "good", "best", "good" };

            var shit=Solution_32.Fuck(")()())");

            //int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            //var shit = Solution_29.Fuck(-2147483648,-1);
            //Console.WriteLine(shit);
         //   int i = 1<<31;
           // Console.Write(i);
             Console.ReadLine();


        }
        static bool Fuck()
        {
            string ori = Console.ReadLine();
            if (ori.Length == 0)
            {
                return false;
            }
            string[] s = ori.Split(',');
            if (s[0].Length == 0)
            {
                return false;
            }
            string[] s_nums = s[0].Split(' ');
            if (s[1].Length == 0)
            {
                return false;
            }
            int N = 0;
            if(!int.TryParse(s[1],out N))
            {
                return false;
            }
            int[] nums = new int[s[0].Length];
            for (int i = 0; i < s_nums.Length; i++)
            {
                if(!int.TryParse(s_nums[i],out nums[i]))
                {
                    return false;
                }
            }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = nums[i];
                int swap = nums[i];
                nums[i] = nums[0];
                nums[0] = swap;
                int front = 1;
                int tail = nums.Length - 1;
                while (front < tail)
                {
                    if (nums[front] + nums[tail] == N - temp)
                    {
                        return true;
                    }
                    else if (nums[front] + nums[tail] > N - temp)
                    {
                        tail--;
                    }
                    else
                    {
                        front++;
                    }
                }
                swap = nums[i];
                nums[i] = nums[0];
                nums[0] = swap;

            }
            return false;

        }

//        int front = 0;
//        int tail = nums.Length - 1;
//        int mid = (tail - front) / 2;
//            while(mid>front&&mid<tail&&tail> front)
//            {
//                if(nums[front]+nums[tail]>N)
//                {
//                    tail--;
//                }
//}
static bool Shit(int[] nums, int N)
        {
            for(int i=0;i<nums.Length;i++)
            {
                for(int j=i+1;j<nums.Length;j++)
                {
                    for(int k=j+1;k<nums.Length;k++)
                    {
                        if(nums[i]+nums[j]+nums[k]==N)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
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
