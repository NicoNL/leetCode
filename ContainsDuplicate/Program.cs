using System;

namespace ContainsDuplicate
{
    class Programm
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            if (set.Count < nums.Length)
            {
                return true;
            }
            return false;
        }

    }
}
