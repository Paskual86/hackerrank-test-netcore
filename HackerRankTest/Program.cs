﻿using HackerRankTest.Helpers;
using HackerRankTest.Tests;

namespace HackerRankTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.AddOption("Big Sum", VeryBigSum.Execute);
            ConsoleHelper.AddOption("Diagonal Difference", DiagonalDifference.Execute);
            ConsoleHelper.AddOption("Plus Minus", PlusMinus.Execute);
            ConsoleHelper.AddOption("Staircase", Staircase.Execute);
            ConsoleHelper.AddOption("Mini-MaxSum", MiniMaxSum.Execute);
            ConsoleHelper.AddOption("Birthday Cake Candles", BirthdayCakeCandles.Execute);
            ConsoleHelper.AddOption("Designer PDF Viewer", DesignerPDFViewer.Execute);
            ConsoleHelper.AddOption("Fizz Buzz", FizzBuzz.Execute);
            ConsoleHelper.AddOption("UserName Changes", UserNameChanges.Execute);
            ConsoleHelper.AddOption("Sales By Match", SalesByMatch.Execute);
            ConsoleHelper.AddOption("Counting Valleys", CountingValleys.Execute);

            
            ConsoleHelper.EnterTheLoop();
        }
    }
}
