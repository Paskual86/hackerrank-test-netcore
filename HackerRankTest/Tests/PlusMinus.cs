using System;
using System.Collections.Generic;

namespace HackerRankTest.Tests
{
    public static class PlusMinus
    {
        public enum Sign
        {
            Negative,
            Positive,
            Zero
        }


        private static Dictionary<Sign, double> ratios;

        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            CountItems(arr);
            PrintResult(arr);
        }

        private static void CountItems(int[] arr)
        {
            ratios = new Dictionary<Sign, double>();
            double positive = 0, negative = 0, zero = 0;
            if (arr.Length == 0) return;

            foreach (var item in arr)
            {
                if (item > 0) positive++;
                else
                {
                    if (item < 0) negative++;
                    else
                    {
                        zero++;
                    }
                }
            }

            ratios.Add(Sign.Negative, negative);
            ratios.Add(Sign.Positive, positive);
            ratios.Add(Sign.Zero, zero);
        }

        private static void PrintResult(int[] arr)
        {
            double countItems = arr.Length;
            if (countItems == 0) return;

            var ratioNegative = Math.Round((ratios[Sign.Negative] / countItems), 6);
            var ratioPositive = Math.Round((ratios[Sign.Positive] / countItems), 6);
            var ratioZero = Math.Round((ratios[Sign.Zero] / countItems), 6);

            Console.WriteLine($"{ratioPositive:0.000000}");
            Console.WriteLine($"{ratioNegative:0.000000}");
            Console.WriteLine($"{ratioZero:0.000000}");
        }

        public static void Execute()
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] arr = new int[] { 1, 1, 0, -1, -1, -8, 16, 0 };
            plusMinus(arr);
        }
    }
}
