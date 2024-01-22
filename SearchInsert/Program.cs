using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace SearchInsert
{
    class Programm
    {
        public int SearchInsert(int[] nums, int target)
        {
            if(nums.Contains(target)) 
            {
                int index = 0;
                for(int i = 0; i < nums.Length; i++) 
                {
                    if (nums[i] == target)
                    {
                        index = i;
                    }
                }
                return index;
            }
            else
            {
                if(target > nums.Max())
                {
                    return nums.Length;

                }
                if(target < nums.Min()) 
                {
                    return 0;
                }
                int index = 0;
                for(int i = 0; i < nums.Length; ++i) 
                {
                    if ((i+1) < nums.Length && nums[i] < target && nums[i+1] > target) 
                    {
                       index = i;
                        break;
                    }
                }
                return index;
            }
        }
    }
}
