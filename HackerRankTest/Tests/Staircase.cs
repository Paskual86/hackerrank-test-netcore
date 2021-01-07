using HackerRankTest.Helpers;

namespace HackerRankTest.Tests
{
    public static class Staircase
    {

        private const int MaxNumberStair = 100;
        private const int MinNumberStair = 1;
        private const char StairChar = '#';
        private const char SpaceChar = ' ';


        private static bool IsValid(int n) 
        {
            return (n >= MinNumberStair && n <= MaxNumberStair);
        }

        private static string AddSpace(int n) 
        {
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                result += SpaceChar;
            }
            return result;
        }

        private static string AddStair(int n)
        {
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                result += StairChar;
            }

            return result;
        }


        static void StairCase(int n)
        {
            if (IsValid(n)) 
            {
                for (int i = 1; i <= n; i++)
                {
                    ConsoleHelper.WL($"{AddSpace(n - i)}{AddStair(i)}");
                }
            }
        }

        static void StairCase2(int n)
        {
            if (IsValid(n))
            {
                string spaceString = string.Empty;
                string StairString = string.Empty;

                for (int i = 1; i <= n; i++) {
                    spaceString += SpaceChar;
                    StairString += StairChar;
                }

                for (int i = 1; i <= n; i++)
                {
                    string r_Stairs = StairString.Substring(0, i);
                    string r_space = spaceString.Substring(0, n - i);
                    ConsoleHelper.WL($"{r_space}{r_Stairs}");
                }
                
            }
        }

        public static void Execute() 
        {
            StairCase2(5);
        }
    }
}
