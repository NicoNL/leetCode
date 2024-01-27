using System;

namespace AddDigits
{
    class Program
    {
        public int AddDigits(int num)
        {
            if (num < 10)
            {
                return num;
            }
            else
            {
                string strNum = num.ToString();
                int sum = 0;
                for(int i = 0; i < strNum.Length; i++) 
                {
                    sum += Convert.ToInt32(strNum[i]) - '0';
                }
                return AddDigits(sum);
            }
        }
    }
}