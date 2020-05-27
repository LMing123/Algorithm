using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_283
    {
        public static void MoveZeroes(ref int[] nums)
        {
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if(nums[i]!=0)
                {
                    var k = nums[j];
                    nums[j] = nums[i];
                    nums[i] = k;
                    j++;
                }

            }
        }
        public static void MoveZeroes2(ref int[] nums)
        {
            for(int i=0,j=0;j<nums.Length;i++)
            {
                if(i<nums.Length)
                {
                    if (nums[i] != 0)
                    {
                        nums[j] = nums[i];
                        j++;
                    }
                }
                else
                {
                    nums[j] = 0;
                    j++;
                }
                
            }
        }
        public static void MoveZeroes1(ref int[] nums)
        {
            var length=  nums.Length;

            for(int i=length-1;i>=0;i--)
            {
                if(nums[i]==0)
                {
                    for(int j=i+1;j<length;j++ )
                    {
                        var k = nums[j];
                        nums[j] = nums[j-1];
                        nums[j-1] = k;                       
                    }
                    length--;
                }
            }
        }
    }
}
