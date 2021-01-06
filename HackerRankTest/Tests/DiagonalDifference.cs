using HackerRankTest.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTest.Tests
{
    public static class DiagonalDifference 
    {
        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = GetArrayTest(3);

            PrintArray(arr);

            //for (int i = 0; i < n; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}

            int result = Result.diagonalDifference(arr);

            ConsoleHelper.WL($"Result: {result}");

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        private static List<List<int>> GetArrayTest(int quantity) 
        {
            var result = new List<List<int>>();
            var r = new Random();

            for (int row = 0; row < quantity; row++)
            {
                var lstAux = new List<int>();
                for (int col = 0; col < quantity; col++)
                {
                    lstAux.Add(r.Next(1, 100));
                }

                result.Add(lstAux);
            }

            return result;
        }

        private static void PrintArray(List<List<int>> arr) 
        {
            for (int row = 0; row < arr.Count; row++)
            {
                string result = string.Empty;
                for (int col = 0; col < arr[row].Count; col++)
                {
                    result += $"{arr[row][col]} ";
                }

                ConsoleHelper.WL(result);
            }
        }
    }

    

    public static class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        private static List<int> maindiagonal;
        private static List<int> secondaryDiagonal;

        private static int matrixrowCount;

        public static int diagonalDifference(List<List<int>> arr)
        {
            secondaryDiagonal = new List<int>();
            maindiagonal = new List<int>();
            int result = 0;

            if (IsValidMatrix(arr))
            {
                matrixrowCount = arr.Count;

                for (int row = 0; row < arr.Count; row++)
                {
                    for (int col = 0; col < arr[row].Count; col++)
                    {
                        if (isValidValue(arr[row][col]))
                        {
                            if (isMainDialog(row, col)) maindiagonal.Add(arr[row][col]);
                            if (isSecondaryDialog(row, col)) secondaryDiagonal.Add(arr[row][col]);
                        }
                    }
                }

                if (maindiagonal.Count == secondaryDiagonal.Count) 
                {
                    int mainSum = SumArray(maindiagonal);
                    int secondarySum = SumArray(secondaryDiagonal);

                    result = Math.Abs(mainSum - secondarySum);
                }
            }

            return result;
        }

        private static int SumArray(List<int> arr) 
        {
            if (arr != null) 
            {
                return arr.Sum();
            }
            return 0;
        }
        private static bool IsValidMatrix(List<List<int>> arr)
        {
            if ((arr == null) || (arr.Count == 0) || (arr.Count != arr[1].Count)) return false;
            return true;
        }

        private static bool isValidValue(int value) 
        {
            return (value >= 1 && value <= 100);
        }

        private static bool isMainDialog(int row, int col) 
        {
            return ((row - col) == 0);
        }
        private static bool isSecondaryDialog(int row, int col)
        {
            return ((matrixrowCount - (row + col)) == 1);
        }

    }
}
