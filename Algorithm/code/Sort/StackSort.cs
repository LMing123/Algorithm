using System;

namespace Algorithm.Code
{
    public class StackSort
    {

        static void OutPut(ref int[] nums,int times)
        {
            Console.WriteLine($"第{times}次调整堆");
            foreach(var t in nums)
            {
                Console.Write($"{t} ");
            }
            Console.WriteLine();
        }
        static void InitOutPut(ref int[] nums,int times)
        {
            Console.WriteLine($"建初堆，第{times}次调整堆");
            foreach(var t in nums)
            {
                Console.Write($"{t} ");
            }
            Console.WriteLine();
        }
        private static void AdjustStack(ref int[] nums, int start,int length)
        {
            for(int j=2*start+1;j< length; j=j*2+1)
            {
                int SpecialS = nums[start];
                if(j+1< length && nums[j]<nums[j+1])
                {
                    j++;
                }
                if (j < length && SpecialS < nums[j])
                {
                    int tem = nums[start];
                    nums[start] = nums[j];
                    nums[j] = tem;
                    start = j ;
                }

            }
        }
        public static int[] Func(int[] nums)
        {
            int[] result = nums;
            int startPositon = (nums.Length / 2);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Init Stack:");
            Console.WriteLine();
            Console.ResetColor();
            for (int i = result.Length / 2 - 1; i >= 0; i--)
            {
                AdjustStack(ref result, i,result.Length);
                InitOutPut(ref result, result.Length / 2  - i);
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Adjust Stack:");
            Console.WriteLine();
            Console.ResetColor();
            for (int j= result.Length-1;j>0;j--)
            {
                int temp = result[j];
                result[j] = result[0];
                result[0] = temp;
                AdjustStack(ref result, 0,j);
                OutPut(ref result, result.Length-j);
            }
            return result;
        }
    }
}
