namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// 88. 合并两个有序数组
    /// </summary>
    class Solution_88
    {
        public static void Func(ref int[] nums1, int m, int[] nums2, int n)
        {
            int length = m;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                while (j <= length && nums1[j] <= nums2[i])
                {
                    j++;
                }
                if (j <= length)
                {

                    int k = m + n - 1;
                    while (k > j)
                    {
                        nums1[k] = nums1[k - 1];
                        k--;
                    }
                    nums1[j] = nums2[i];

                    length++;

                }
                else
                {
                    nums1[length] = nums2[i];
                    length++;
                }

            }
        }
    }
}
