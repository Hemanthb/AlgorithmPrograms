using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Sorting
    {
        public void InsertionSort(string[] wordArray)
        {
            for (int i = 1; i < wordArray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (wordArray[j].CompareTo(wordArray[i]) > 0)
                    {
                        string temp = wordArray[j];
                        wordArray[j] = wordArray[i];
                        wordArray[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array is:");
            for (int i = 0; i < wordArray.Length; i++)
                Console.WriteLine(wordArray[i]);

        }
    }
}
