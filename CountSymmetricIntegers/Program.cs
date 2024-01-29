using System;

namespace CountSymmetricIntegers
{
    class Program
    {
        public int CountSymmetricIntegers(int low, int high)
        {
            int cnt = 0;
            for (int i = low; i <= high; i++)
            {
                string numStr = i.ToString();
                if (numStr.Length % 2 == 0)
                {
                    int half = numStr.Length / 2;
                    int sum1 = 0;
                    int sum2 = 0;
                    for (int j = 0; j < numStr.Length; j++)
                    {
                        if (j < half)
                        {
                            int temp = i % 10;
                            i = i / 10;
                            sum1 += temp;
                        }
                        else
                        {
                            int temp = i % 10;
                            i = i / 10;
                            sum2 += temp;
                        }

                    }
                    if (sum1 == sum2)
                    {
                        cnt++;
                    }
                }

            }
            return cnt;
        }
    }
}