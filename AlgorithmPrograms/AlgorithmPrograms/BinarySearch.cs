using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BinarySearch
    {
        public void SearchWord(String[] wordArray,int start,int end,string word)
        {
            if (end >= start)
            {
                int midPt = start + (end - start)/ 2;
                string midword = wordArray[midPt];

                if (midword.Equals(word))
                {
                    Console.WriteLine("Required word - {0} is found", word);
                    return;
                }
                if (midword.CompareTo(word)>0)
                {
                    SearchWord(wordArray, 0, midPt - 1, word);
                    return;

                }
                if (midword.CompareTo(word) < 0)
                {
                    SearchWord(wordArray, midPt + 1, end, word);
                    return;

                }
               
            }
            Console.WriteLine("Required word - {0} is not found", word);
            return;
        }
    }
}
