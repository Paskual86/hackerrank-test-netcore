using System;
using System.Linq;

namespace HackerRankTest.Tests
{
    public static class ArrayManipulation
    {

        private static int MinSizeArray = 3;
        private static int MaxSizeArray = (int)Math.Pow(10, 7);

        private static int MaxNumberOfOperation = 2 * (int)Math.Pow(10, 5);
        private static int MinNumberOfOperation = 1;

        private static long MinValueOfK = 0;
        private static long MaxValueOfK = (int)Math.Pow(10, 10);

        public static void Execute() 
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = arrayManipulation(n, queries);

        }

        /// <summary>
        /// Complexity O (N+K)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        static long arrayManipulation(int n, int[][] queries)
        {
            long[] arr_result = new long[n+2];

            int indexFrom;
            int indexTo;
            int value;

            int M = queries.Length;


            for (int row = 0; row < M; row++)
            {
                indexFrom = queries[row][0];
                indexTo = queries[row][1];
                value = queries[row][2];

                arr_result[indexFrom] += value;
                arr_result[indexTo + 1] -= value;
            }

            long accumulated =0;
            long max = 0;
            for (int i = 0; i < arr_result.Length; i++)
            {
                accumulated += arr_result[i];
                max = Math.Max(max, accumulated);
            }
            return max;
        }


    }
}
