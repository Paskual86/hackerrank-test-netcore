using System;

namespace HackerRankTest.Tests
{
    public static class MiniMaxSum
    {
        private static int MinValue = 1;
        private static int MaxValue = (int)Math.Pow(10, 9);

        private static bool IsValid(int n) 
        {
            return (n >= MinValue && n <= MaxValue);
        }

        private static long SumExceptValue(int[]arr, int exceptposition) 
        {
            long result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (IsValid(arr[i]) && i != exceptposition) result += arr[i];
            }

            return result;
        }

        static void miniMaxSum(int[] arr)
        {
            long[] OperationResult = new long[arr.Length];
            
            for (int i = 0; i < arr.Length; i++)
            {
                OperationResult[i] = SumExceptValue(arr, i);
            }

            Array.Sort(OperationResult);

            Console.WriteLine($"{OperationResult[0]} {OperationResult[OperationResult.Length-1]}");

        }

        public static void Execute() 
        {
            
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] arr = new int[] { 1, 3, 5, 7, 9 };
            miniMaxSum(arr);
        }
    }
}
