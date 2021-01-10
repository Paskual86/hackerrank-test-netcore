using System;

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


        static long arrayManipulation(int n, int[][] queries)
        {
            long[] arr_result = new long[n];

            int indexFrom;
            int indexTo;
            int value;

            int M = queries.Length;
            int row = 0;
            while (M-- > 0) 
            {
                indexFrom = queries[row][0] - 1;
                indexTo = queries[row][1] - 1;
                value = queries[row][2];
                arr_result = FillArray(arr_result, indexFrom, indexTo, value);
                row++;
            }

            return GetMaximun(arr_result);
        }

        private static long[] FillArray(long[] arr, int indexFrom, int indexTo, int value) 
        {
            long[] result = new long[arr.Length];

            Array.Copy(arr, result, arr.Length);

            int index = indexFrom;

            while (index <= indexTo) 
            {
                result[index] += value;
                index++;
            }
            return result;
        }


        private static long[][] FillArray(long[][] arr, int FirstRow, int indexFrom, int indexTo, long value) 
        {
            long[][] result = new long[arr.Length][];
            for (int row = 0; row < arr.Length; row++)
            {
                result[row] = new long[arr[row].Length];
                if ((row != 0) && (row + 1 >= FirstRow))
                {
                    for (int col = 0; col < arr[row].Length; col++)
                    {
                        if (col >= indexFrom && col <= indexTo)
                        {
                            result[row][col] += arr[row][col] + value;
                        }
                        else
                        {
                            result[row][col] = arr[row][col];
                        }
                    }
                }
                else
                {
                    for (int col = 0; col < arr[row].Length; col++)
                    {
                        result[row][col] = arr[row][col];
                    }
                }
            }

            PrintMatrix(result);

            return result;
        }

        private static void PrintMatrix(long[][] matrix) 
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }

        }

        private static bool IsValidK(long k)
        {
            return k >= MinValueOfK && k <= MaxValueOfK;
        }

        private static long GetMaximun(long[] arr) 
        {
            long result = 0;

            for (int row = 0; row < arr.Length; row++)
            {
                if (result < arr[row]) result = arr[row];
            }

            return result;
        }

    }
}
