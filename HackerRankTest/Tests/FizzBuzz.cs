using System;

namespace HackerRankTest.Tests
{

    public static class MathOperation 
    {

        public static bool IsMultiple(int div, int value) 
        {
            if (div > 0) {

                int divResult = value / div;
                int divResto = value % div;

                if ((divResult > 0) && (divResto == 0))
                {
                    return true;
                }
                else {
                    return false;
                }
                
            }
            return false;
        }
    }

    public static class ResultFizzBuzz
    {

        /*
         * Complete the 'fizzBuzz' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        private const string FIZZBUZZ = "FizzBuzz";
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";

        private static int MaxValue = 2 * (int)Math.Pow(10, 5);

        public static void fizzBuzz(int n)
        {
            if (IsValid(n))
            {
                for (int i = 1; i <= n; i++)
                {
                    bool isMultiple3 = MathOperation.IsMultiple(3, i);
                    bool isMultiple5 = MathOperation.IsMultiple(5, i);

                    if (isMultiple3 && isMultiple5)
                    {
                        System.Console.WriteLine(FIZZBUZZ);
                    }
                    else
                    {
                        if (isMultiple3)
                        {
                            System.Console.WriteLine(FIZZ);
                        }
                        else
                        {
                            if (isMultiple5)
                            {
                                System.Console.WriteLine(BUZZ);
                            }
                            else
                            {
                                System.Console.WriteLine($"{i}");
                            }
                        }
                    }
                }
            }
        }

        private static bool IsValid(int n) 
        {
            return n > 0 && n < MaxValue;

        }

    }

    public static class FizzBuzz
    {

        public static void Execute() 
        {

            ResultFizzBuzz.fizzBuzz(15);
            //var result1 = MathOperation.IsMultiple(5, 15);
        }
    }
}
