using System;
using System.Collections.Generic;
using System.Linq;

namespace OPPArrays.Logic
{
    internal class NRnumbers
    {
        private int[] _array;

        public int N { get; private set; }

        public NRnumbers(int[] array)
        {
            _array = array;
            N = array.Length;
        }

        public List<int> GetNonRepeatingNumbers()
        {
            Dictionary<int, int> countDictionary = new Dictionary<int, int>();

            for (int i = 0; i < N; i++)
            {
                if (!countDictionary.ContainsKey(_array[i]))
                {
                    countDictionary[_array[i]] = 1;
                }
                else
                {
                    countDictionary[_array[i]]++;
                }
            }

            List<int> nonRepeatingNumbers = countDictionary.Where(kvp => kvp.Value == 1).Select(kvp => kvp.Key).ToList();
            return nonRepeatingNumbers;
        }
    }
}
