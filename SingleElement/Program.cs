using System;
using System.Runtime.Intrinsics.X86;

namespace SingleElement
{
    class Programm
    {
        public int SingleNumber(int[] nums)
        {
            int cnt = 0;
            int single = 0;
            for(int i=0; i<nums.Length; i++)
            {

                for(int j=0;j<nums.Length; j++) 
                {
                    if (nums[i] == nums[j] && i != j)
                    {
                        cnt = 0;
                        break;
                    }
                    else
                    {
                        single = nums[i];
                        cnt++;
                    }
                }
                if(cnt == nums.Length )
                {
                    break;

                }
            }
            return single;
        }
    }
}