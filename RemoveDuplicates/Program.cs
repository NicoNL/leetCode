using System;
using System.Runtime.Intrinsics.X86;

namespace RemoveDuplicates
{
    class Program
    {
        public int RemoveDuplicates(int[] nums)
        {
            int[] tempArr = new int[nums.Length];
            int cnt = 0;
            bool zero = true;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 < nums.Length && nums[i] == nums[i + 1] && !(tempArr.Contains(nums[i])))
                {
                    tempArr[cnt] = nums[i];
                    cnt++;
                }
                else if (!(tempArr.Contains(nums[i])))
                {
                    tempArr[cnt] = nums[i];
                    cnt++;
                }
                else if (nums[i] == 0 && zero)
                {
                    tempArr[cnt] = 0;
                    cnt++;
                    zero = false;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = tempArr[i];
            }
            return cnt;
        }
    }
}