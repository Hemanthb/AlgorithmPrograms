using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class StringPermutation
    {
        
            public static void Permute(String str, int start, int len)
            {
                if (start == len)
                    Console.Write(str+" ");
                else
                {
                    for (int i = start; i <= len; i++)
                    {
                        str = Swap(str, start, i);
                        Permute(str, start + 1, len);
                        str = Swap(str, start, i);
                    }
                }
            }

            public static String Swap(String a,
                                    int i, int j)
            {
                char temp;
                char[] charArray = a.ToCharArray();
                temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
                string s = new string(charArray);
                return s;
            }

        }

}
