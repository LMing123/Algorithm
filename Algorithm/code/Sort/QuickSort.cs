using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code
{
    public class QuickSort
    {
        private static int Sort(ref int[] nums,int left,int right)
        {
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
            return right;

        }

        public static int[] Fuck(ref int[] nums,int left,int right)
        {
            int[] result = nums;
            if (left >= right)
                return result;
            int position=Sort(ref result, left, nums.Length - 1);
            Fuck(ref result, left, position - 1);
            Fuck(ref result,  position + 1,right);
            return result;
        }
    }
}
