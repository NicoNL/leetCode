using System;

namespace ThirdMax
{
    class Program
    {
        public int ThirdMax(int[] nums)
        {
            Array.Sort(nums);
            int max3 = 0;
            int max2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int max = nums.Max();
                if (nums[i] < max)
                {
                    max2 = nums[i]; 
                }
                else if (nums[i] == max)
                {
                    break;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < max2)
                {
                    max3 = nums[i];
                }
                else if (nums[i] == max2)
                {
                    break;
                }
            }
            if(max3 == 0 && nums.Contains(0))
            {
                return max3;
            }
            if(max3 == 0) 
            {
                max3 = max2;
                return nums.Max();
            }
            return max2;
        }
   
    }
}