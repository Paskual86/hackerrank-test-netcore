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

            ConsoleHelper.EnterTheLoop();
        }
    }
}
