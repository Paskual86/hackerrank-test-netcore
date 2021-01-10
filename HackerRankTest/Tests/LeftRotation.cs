using System;

namespace HackerRankTest.Tests
{
    public static class LeftRotation
    {
        public static void Execute() 
        {
            string[] nd = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nd[0]);
            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] result = rotLeft(a, d);
        }

        static int[] rotLeft(int[] a, int d)
        {
            int[] result = new int[a.Length];
            int move = result.Length - d;

            if (move > 0)
            {
                Array.Copy(a, d, result, 0, move);
                Array.Copy(a, 0, result, move, d);

            }
            else { 
                
            }
            return result;
        }
    }
}
