using System;
using System.Collections.Generic;
using System.Linq;

namespace OPPArrays.Logic
{
    internal class MRnumbers
    {
        private int[] _array;

        public int N { get; private set; }

        public MRnumbers(int[] array)
        {
            _array = array;
            N = array.Length;
        }

        public List<int> GetMostRepeatedNumbers()
        {
            Dictionary<int, int> countDictionary = new Dictionary<int, int>();

            for (int i = 0; i < N; i++)
            {
                if (countDictionary.ContainsKey(_array[i]))
                {
                    countDictionary[_array[i]]++;
                }
                else
                {
                    countDictionary[_array[i]] = 1;
                }
            }

            int maxFrequency = countDictionary.Values.Max();
            List<int> mostRepeatedNumbers = countDictionary.Where(kvp => kvp.Value == maxFrequency).Select(kvp => kvp.Key).ToList();
            return mostRepeatedNumbers;
        }
    }
}
