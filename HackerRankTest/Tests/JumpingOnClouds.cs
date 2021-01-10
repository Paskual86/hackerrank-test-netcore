using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTest.Tests
{
    public static class JumpingOnClouds
    {
        private const short MAXITEMS = 100;
        private const short MINITEMS = 2;
        private const short CUMULUS = 0;
        private const short THUNDERHEADS = 1;
        private const short PROHIBITED = -1;




        public static void Execute() 
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c);

            Console.WriteLine($"Jumps: {result}");
        }

        static int jumpingOnClouds(int[] c)
        {
            int result = 0;
            
            if (IsValid(c)) 
            {
                int[] clouds =  ConvertToPath(c);

                bool bLoop = true;
                int index = 0;
                List<int> jumpResult = new List<int>();

                while (bLoop) 
                {
                    int indexValue = clouds[index];

                    if (indexValue != PROHIBITED)
                    {
                        if (!jumpResult.Contains(indexValue))
                        {
                            jumpResult.Add(indexValue);
                        }

                        if (index + 1 < clouds.Length)
                        {
                            int indexNextValue = clouds[index + 1];

                            int indexNextPer2Value;
                            if (index + 2 < clouds.Length)
                            {
                                indexNextPer2Value = clouds[index + 2];
                            }
                            else
                            {
                                indexNextPer2Value = PROHIBITED;
                            }

                            if ((indexNextPer2Value - indexValue) == 2)
                            {
                                jumpResult.Add(indexNextPer2Value);
                                index += 2;
                            }
                            else
                            {
                                if (indexNextValue != PROHIBITED)
                                {
                                    jumpResult.Add(indexNextValue);
                                }
                                index++;
                            }

                        }
                        else
                        {
                            bLoop = false;
                        }
                    }
                    else
                    {
                        index++;
                    }
                }

                result = jumpResult.Count()-1;
            }

            return result;
        }

        private static bool IsValid(int[] c) 
        {
            return c.Length >= MINITEMS && c.Length <= MAXITEMS;
        }

        private static int[] ConvertToPath(int[] c) 
        {
            int[] result = null;
            if (IsValid(c)) 
            {
                result = new int[c.Length];
                for (int i = 0; i < c.Length; i++)
                {
                    switch (c[i]) 
                    {
                        case CUMULUS: result[i] = i; break;
                        case THUNDERHEADS: result[i] = PROHIBITED; break;
                        default:break;
                    }
                }
            }
            return result;
        }

    }
}
