using System;

namespace RemoveElement
{
    class Program
    {
        public int RemoveElement(int[] nums, int val)
        {
            int[] nums2 = new int[nums.Length];
            int cnt = 0;
            foreach (int num in nums)
            {
                if (num != val)
                {
                    nums2[cnt] = num;
                    cnt++;
                }
            }
            for(int i = 0; i < nums2.Length;i++)
            {
                nums[i] = nums2[i];
            }
            return cnt;
        }
    }
}