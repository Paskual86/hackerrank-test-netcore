using HackerRankTest.Helpers;
using System;

namespace HackerRankTest.Tests
{
    public static class VeryBigSum
    {
        /* DESCRIPTION
         In this challenge, you are required to calculate and print the sum of the elements in an array, keeping in mind that some of those integers may be quite large.

            Function Description

            Complete the aVeryBigSum function in the editor below. It must return the sum of all array elements.

            aVeryBigSum has the following parameter(s):

            int ar[n]: an array of integers .
            Return

            long: the sum of all array elements
            Input Format

            The first line of the input consists of an integer .
            The next line contains  space-separated integers contained in the array.

            Output Format

            Return the integer sum of the elements in the array.

            Constraints


            Sample Input

            5
            1000000001 1000000002 1000000003 1000000004 1000000005
            Output

            5000000015
            Note:

            The range of the 32-bit integer is .
            When we add several integer values, the resulting sum might exceed the above range. You might need to use long int C/C++/Java to store such sums.
         */

        private static long MaxNumber;
        private static long MinNumber;

        private static int MaxQuantityOfArray;
        private static int MinQuantityOfArray;

        public static void Execute() 
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            /*
            int arCount = Convert.ToInt32(Console.ReadLine());
            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            */


            int arCount = 5;
            long[] ar = new long[] { 5000000, 500001, 80005246, 7856212, 1000001 };

            MaxNumber = (long) Math.Pow(10, 10);
            MinNumber = 0;

            MaxQuantityOfArray = 10;
            MinQuantityOfArray = 1;

            long result = aVeryBigSum(ar, arCount);

            ConsoleHelper.WL($"Operation Result {result}");

            //textWriter.Flush();
            //textWriter.Close();
        }

        static long aVeryBigSum(long[] ar, int arCount)
        {
            long result = 0;

            if (IsValidQuantityInArray(arCount))
            {
                int i = 0;
                foreach (var value in ar)
                {
                    if (IsValid(value)) result += value;
                    i++;
                    if (i > arCount) break;
                }
            }

            return result;
        }

        static bool IsValid(long value) 
        {
            return (value >= MinNumber && value <= MaxNumber);
        }

        static bool IsValidQuantityInArray(int value)
        {
            return (value >= MinQuantityOfArray && value <= MaxQuantityOfArray);
        }
    }
}
