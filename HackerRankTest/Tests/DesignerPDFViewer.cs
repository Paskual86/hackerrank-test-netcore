using System.Collections.Generic;

namespace HackerRankTest.Tests
{
    public static class DesignerPDFViewer
    {

        public static void Execute() 
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int[] h = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            //string word = "abc";
            int[] h = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            string word = "zaba";


            int result = designerPdfViewer(h, word);
            System.Console.WriteLine($"Result {result}");
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        private static Dictionary<char, int> _letterHeight;

        static int designerPdfViewer(int[] h, string word)
        {
            int result = 0;

            if (IsValid(h) && IsValid(word)) result = CalculateArea(h, word);

            return result;
        }

        private static bool IsValid(int[] h) 
        {
            return h.Length == 26;
        }

        private static bool IsValid(int h) 
        {
            return h >= 1 && h <= 7;
        }

        private static bool IsValid(string word) 
        {
            return word.Length >= 0 && word.Length <= 10;
        }

        private static void LoadLetterHeight(int[] h) 
        {
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            if (IsValid(h))
            {
                _letterHeight = new Dictionary<char, int>();
                for (int i = 0; i < h.Length; i++)
                {
                    _letterHeight.Add(letters[i], IsValid(h[i]) ? h[i] : 0);
                }
            }
        }

        private static int CalculateArea(int[] h, string word) 
        {
            LoadLetterHeight(h);

            int tallest = 0;

            for (int i = 0; i < word.Length; i++) {
                if (tallest < _letterHeight[word[i]]) tallest = _letterHeight[word[i]];
            }

            return tallest*word.Length;
        }
    }
}
