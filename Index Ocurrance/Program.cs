using System;
using System.Runtime.Intrinsics.X86;

namespace RemoveElement
{
    class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(StrStr("mississippi", "pi"));
        }
        static public int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                List<int> list = new List<int>();
                for(int i= 0;i <haystack.Length; i++)
                {
                    if (haystack[i] == needle[0])
                    list.Add(i);
                }
                int position = 0;
                
                foreach (int i in list) 
                {
                    int cnt = 0;
                    bool checker = true;
                    for(int j = 0;checker && j< needle.Length;j++)
                    {
                        for(int k= i;k < haystack.Length;k++)
                        {
                            if (needle[j] == haystack[k])
                            {
                                cnt++;
                                j++;
                            }
                            else if (needle[j] != haystack[k])
                            {
                                checker = false;
                                break;
                            }
                            if (cnt == needle.Length)
                            {
                                checker = false;
                                break;
                                
                            }
                            
                        }
                    }
                    if (cnt == needle.Length)
                    {
                        position = i;
                        break;
                    }
                }
                return position;
            }
            else 
            {
                return -1;
            }
        }
    }
}