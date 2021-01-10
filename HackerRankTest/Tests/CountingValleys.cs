using System;

namespace HackerRankTest.Tests
{

    public static class CountingValleyResult
    {
        private const char UPHILL = 'U';
        private const short UPHILL_NUMBER = 1;
        private const char UPHILL_ICON = '/';
        private const char DOWNHILL = 'D';
        private const char DOWNHILL_ICON = '\\';
        private const short DOWNHILL_NUMBER = -1;

        private static int MAXSTEPS = (int) Math.Pow(10, 6);
        private static int MINSTEPS = 2;


        public static int countingValleys(int steps, string path)
        {
            int result = 0;
            if (IsValidPath(path))
            {
                short[] pathConverted = ConvertPathToValue(path);
                int hike = 0;
                bool isMountain = false;
                bool isVallley = false;
                for (int i = 0; i < pathConverted.Length; i++)
                {
                    hike += pathConverted[i];
                    if (hike == 0)
                    {
                        if (isMountain)
                        {

                        }
                        else
                        {
                            if (isVallley)
                            {
                                result++;
                            }
                        }

                        isVallley = isMountain = false;
                    }
                    else 
                    {
                        if (hike > 0)
                        {
                            isMountain = true;
                        }
                        else 
                        {
                            isVallley = true;
                        }
                    }
                }
            }

            return result;
        }

        private static bool IsValidPath(string path) 
        {
            return ((MINSTEPS <= path.Length) && (path.Length <= MAXSTEPS));
        }

        private static short[] ConvertPathToValue(string path) 
        {
            short[] result = null;

            if (IsValidPath(path))
            {
                result = new short[path.Length];

                for (int i = 0; i < path.Length; i++)
                {
                    switch (path[i])
                    {
                        case UPHILL: result[i] = UPHILL_NUMBER;break;
                        case DOWNHILL: result[i] = DOWNHILL_NUMBER; break;
                        default:
                            break;
                    }
                }
            }

            return result;
        }

    }



    public static class CountingValleys
    {

        public static void Execute() 
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());
            string path = Console.ReadLine();
            int result = CountingValleyResult.countingValleys(steps, path);
            Console.WriteLine($"Valleys: {result}");
        }
    }
}
