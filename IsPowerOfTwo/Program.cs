using System;

namespace IsPowerOfTwo
{
    //SOLUTION BASED ON KeerthiVarmanK's phyton solution
    class Programm
    {
        public class Solution
        {
            public bool IsPowerOfTwo(int n)
            {
                if (n == 1)
                {
                    return true;
                }
                else if (n == 0 || (n % 2) != 0)
                {
                    return false;
                }
                return IsPowerOfTwo(n / 2);
            }
        }
    }
}
