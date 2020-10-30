using System;
using System.Collections.Generic;
using System.Text;

namespace Tomas.Duran.Agilesight.Test
{
    public class Permutations
    {
        //TODO: implement if complexity is mayor to N send warning.
        public static long GetPermutationComplexity(string word)
        {
            int wordSize = word.Length;
            long complexity = 0;
            for (int i = wordSize; i > 1; i--)
            {
                complexity += Factorial(wordSize) / Factorial(wordSize - i);
            }
            return complexity;
        }

        public static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }

        public static List<string> FindPermutations(string word)
        {

            char[] arr = word.ToUpper().ToCharArray();

            List<string> result = new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                result.AddRange(FindPermutations(arr, arr[i].ToString(), new List<int>() { i }));
            }

            return result;
        }

        private static List<string> FindPermutations(char[] arr, string current, List<int> currentIndexes)
        {

            List<string> result = new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (currentIndexes.Contains(i))
                    continue;

                List<int> nextIndexes = new List<int>(currentIndexes);

                String m = current + arr[i];

                result.Add(m);

                nextIndexes.Add(i);

                result.AddRange(FindPermutations(arr, m, nextIndexes));
            }

            return result;
        }
    }
}
