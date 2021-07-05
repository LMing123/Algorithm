using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code
{
    public class QuickSort
    {

        public static void Sort3(ref int[] nums, int start, int end)
        {
            if (start >= end) return;

            int startIndex = start;
            int endIndex = end;
            int flag = nums[startIndex];
            while (startIndex < endIndex)
            {
                while (startIndex < endIndex && nums[endIndex] >= flag)
                    endIndex--;
                nums[startIndex] = nums[endIndex];

                while (startIndex < endIndex && nums[startIndex] <= flag)
                    startIndex++;
                nums[endIndex] = nums[startIndex];


            }
            nums[startIndex] = flag;
            Sort3(ref nums, start, endIndex - 1);
            Sort3(ref nums, endIndex + 1, end);


        }

        public static void Sort2(ref int[] nums, int start, int end)
        {
            if (start >= end) return;
            int startIndex = start;
            int endIndex = end;
            int flag = nums[startIndex];
            while (startIndex < endIndex)
            {
                while (endIndex >= start && startIndex < endIndex)
                {
                    if (nums[endIndex] < flag)
                    {
                        var tem = nums[startIndex];
                        nums[startIndex] = nums[endIndex];
                        nums[endIndex] = tem;
                        startIndex++;
                        break;
                    }
                    endIndex--;
                }
                while (startIndex <= end && startIndex < endIndex)
                {
                    if (nums[startIndex] > flag)
                    {
                        var tem = nums[endIndex];
                        nums[endIndex] = nums[startIndex];
                        nums[startIndex] = tem;
                        endIndex--;
                        break;

                    }
                    startIndex++;
                }
            }
            nums[startIndex] = flag;
            Sort2(ref nums, start, startIndex - 1);
            Sort2(ref nums, startIndex + 1, end);
        }

        private static int Sort(ref int[] nums, int left, int right)
        {
            int key = nums[left];
            int positon = left;
            while (left < right)
            {
                while (left < right)
                {
                    if (nums[right] < key)
                    {
                        int temp = nums[left];
                        nums[left] = nums[right];
                        nums[right] = temp;
                        if (right == positon)
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
                        if (left == positon)
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

        public static int[] Func(ref int[] nums, int left, int right)
        {
            int[] result = nums;
            if (left >= right)
                return result;
            int position = Sort(ref result, left, nums.Length - 1);
            Func(ref result, left, position - 1);
            Func(ref result, position + 1, right);
            return result;
        }
    }
}
