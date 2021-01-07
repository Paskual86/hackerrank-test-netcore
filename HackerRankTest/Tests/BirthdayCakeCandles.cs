using HackerRankTest.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTest.Tests
{
    public static class BirthdayCakeCandles
    {

        private static int MinSizeCandle = 1;
        private static int MaxSizeCandle = (int)Math.Pow(10, 5);

        private static int MinHeightCandle = 1;
        private static int MaxHeightCandle = (int) Math.Pow(10,7);

        private static bool IsValidCandle(int n) 
        {
            return (n >= MinSizeCandle && n <= MaxSizeCandle);
        }

        private static bool IsValidHeightCandle(int height) 
        {
            return height >= MinHeightCandle && height <= MaxHeightCandle;
        }

        private static int birthdayCakeCandles(List<int> candles)
        {
            var candlesAux = candles.ToArray();
            Array.Sort(candlesAux);
            Array.Reverse(candlesAux);
            

            int tallest = 0;

            for (int i = 0; i < candlesAux.Length; i++)
            {
                if (IsValidHeightCandle(candlesAux[i]))
                {
                    tallest = candlesAux[i];
                    break;
                }
            }

            return candles.Count(wh => wh == tallest);
        }

        public static void Execute()
        {
            var lst = new List<int>
            {
                18,
                90,
                90,
                13,
                90,
                75,
                8,
                90,
                43

            };
            ConsoleHelper.WL($"{birthdayCakeCandles(lst)}");
        }

        
    }
}
