using System;
using System.Collections.Generic;

namespace HackerRankTest.Tests
{
    public static class NewYearChaos
    {
        private const short MAX_BRIBES = 10;
        private const short MIN_BRIBES = 1;
        private const short MAX_NUMBER_BRIBES = 2;

        private static int MIN_VALUE = 1;
        private static int MAX_VALUE = (int)Math.Pow(10,5);


        public static void Execute() 
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
                minimumBribes(q);
            }
        }

        static void minimumBribes(int[] q)
        {
            if (q != null && q.Length > 0)
            {
                int totalbribes = 0;

                int expectedFirst = 1;
                int expectedSecond = 2;
                int expectedThird = 3;

                bool isTooChaotic = false;
                for (int i = 0; i < q.Length; i++)
                {
                    if (q[i] == expectedFirst)
                    {
                        expectedFirst = expectedSecond;
                        expectedSecond = expectedThird;
                        expectedThird++;
                    }
                    else
                    {
                        if (q[i] == expectedSecond)
                        {
                            totalbribes++;
                            expectedSecond = expectedThird;
                            expectedThird++;
                        }
                        else
                        {
                            if (q[i] == expectedThird)
                            {
                                totalbribes += 2;
                                expectedThird++;
                            }
                            else
                            {
                                isTooChaotic = true;
                                Console.WriteLine("Too chaotic");
                                break;
                            }
                        }
                    }
                }

                if (!isTooChaotic) Console.WriteLine($"{totalbribes}");
            }
        }

        static void minimumBribes2(int[] q)
        {
            if (q != null && q.Length > 0)
            {
                List<int> bribes = new List<int>();
                int index;

                int totalbribes = 0;

                int expectedFirst = 1;
                int expectedSecond = 2;
                int expectedThird = 3;

                bool isTooChaotic = false;
                for (int i = 0; i < q.Length; i++)
                {
                    if (q[i] == expectedFirst)
                    {
                        expectedFirst = expectedSecond;
                        expectedSecond = expectedThird;
                        expectedThird++;
                    }
                    else {
                        if (q[i] == expectedSecond)
                        {
                            totalbribes++;
                            expectedSecond = expectedThird;
                            expectedThird++;
                        }
                        else { 
                            if (q[i] == expectedThird)
                            {
                                totalbribes += 2;
                                expectedThird++;
                            }
                            else
                            {
                                isTooChaotic = true;
                                Console.WriteLine("Too chaotic");
                                break;
                            }
                        }
                    }
                }

                if (!isTooChaotic) Console.WriteLine($"{totalbribes}");
                /*
                for (int i = 0; i < q.Length; i++)
                {
                    index = q.ToList().IndexOf(i + 1);
                    bribes.Add(index - i);
                }

                int minValue = bribes.Min();
                if (Math.Abs(minValue) > MAX_NUMBER_BRIBES)
                {
                    Console.WriteLine("Too chaotic");
                }
                else
                {
                    int more = bribes.Where(wh => wh > MAX_NUMBER_BRIBES).Sum(sm => sm - (MAX_NUMBER_BRIBES+1));
                    Console.WriteLine($"{ Math.Abs(bribes.Where(wh => wh < 0).Sum()) + more}");
                }*/
            }
        }

        private static bool IsValidBribes(int t) 
        {
            return t >= MIN_BRIBES && t <= MAX_BRIBES;
        }

        private static bool IsValidValue(int value) 
        {
            return value >= MIN_VALUE && value <= MAX_VALUE;
        }

    }
}
