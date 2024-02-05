using System;
using System.Collections.Generic;

namespace OPPArrays.Logic
{
    internal class NPrimos
    {
        private int[] _array;

        public int N { get; private set; }

        public NPrimos(int[] array)
        {
            _array = array;
            N = array.Length;
        }

        public List<int> GetPrimeNumbers()
        {
            List<int> primeNumbers = new List<int>();

            for (int i = 0; i < N; i++)
            {
                if (IsPrime(_array[i]))
                {
                    primeNumbers.Add(_array[i]);
                }
            }

            return primeNumbers;
        }

        private bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
