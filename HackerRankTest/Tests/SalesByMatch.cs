using System;
using System.Linq;

namespace HackerRankTest.Tests
{
    public static class SalesByMatch
    {
        public static void Execute() 
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int n = 9;
            //int[] ar = new int[] { 1, 2, 1, 2, 1, 3, 2 };
            int[] ar = new int[] { 10,20,20,10,10,30,50,10,20 };

            int result = sockMerchant(n, ar);
            System.Console.WriteLine($"Number of pairs: {result}");
        }

        static int sockMerchant(int n, int[] ar)
        {
            int result = 0;
            if (IsValidCount(n) && IsValidSocks(n, ar)) 
            {
                int[] arrAux = new int[ar.Length];
                ar.CopyTo(arrAux, 0);
                Array.Sort(arrAux);

                int index = 0;
                while (arrAux.Length > 0) 
                {
                    int pair = arrAux[index];
                    int count = arrAux.Where(sl => sl == pair).Count();
                    if (count > 0) 
                    {
                        int[] arrPair = new int[count];
                        arrAux.Where(sl => sl == pair).ToArray().CopyTo(arrPair, 0);
                        // remove items
                        arrAux = arrAux.Where(sl => sl != pair).ToArray();
                        result += (int)(arrPair.Count() / 2);
                    }
                }
            }
            return result;

        }
        private static bool IsValidCount(int n) 
        {
            return n >= 1 && n <= 100;
        }

        private static bool IsValidSocks(int n, int[] ar)
        {
            return ((ar != null) && (ar.Length > 0));
        }

        private static bool IsValidValue(int value, int max)
        {
            return value >= 0 && value < max;
        }

    }
}
