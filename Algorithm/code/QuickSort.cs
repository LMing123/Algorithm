using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.code
{
    public class QuickSort
    {
        private static void Sort(ref int[] nums,int left,int right)
        {
            if (left == right)
                return;
            int key = nums[left];
            int positon = left;
            while(left<right)
            {
                while(left<right)
                {
                    if (nums[right] < key)
                    {
                        int temp = nums[left];
                        nums[left] = nums[right];
                        nums[right] = temp;
                        if(right==positon)
                        {
                            positon = left;
                        }
                        break;
                    }
                    right--;
                }
                while (left < right)
                {
                    if (nums[left] > key)
                    {
                        int temp = nums[left];
                        nums[left] = nums[right];
                        nums[right] = temp;
                        if(left==positon)
                        {
                            positon = right;
                        }
                        break;
                    }
                    left++;
                }
            }
            Sort(ref nums, 0, positon);
            Sort(ref nums, positon, right);

        }
        public static int[] Fuck(int[] nums)
        {
            int[] result = nums;
            Sort(ref result, 0, nums.Length - 1);
            return result;
        }
    }
}
