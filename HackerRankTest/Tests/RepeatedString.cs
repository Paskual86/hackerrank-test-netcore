using System;
using System.Linq;
using System.Text;

namespace HackerRankTest.Tests
{
    public static class RepeatedString
    {
        private static long MAXQUANTITYOFLETTERS = (long)Math.Pow(10, 12);
        private static int MINQUANTITYOFLETTERS = 1;

        private const int MAX_LENGTH_STRING = 100;
        private const int MIN_LENGTH_STRING = 1;
        private const char A = 'a';

        public static void Execute() 
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine($"repeated : {result}");
        }


        static long repeatedString(string s, long n)
        {
            long result = 0;
            if (IsValidLengthString(s) && IsValidQuantityOfLetters(n)) 
            {
                if (s.Length > 1)
                {
                    long quantityOfA = 0;
                    long quantityOfLetters = s.Length;
                    long quantityOfALetters = s.Count(c => c == A);
                    long quantity = n / quantityOfLetters;
                    long resto = n % quantityOfLetters;

                    quantityOfA = quantity * quantityOfALetters;
                    if (resto > 0) 
                    {
                        bool bLoop = true;
                        StringBuilder sb = new StringBuilder();
                        sb.Append(s);
                        while (bLoop) 
                        {
                            if (sb.Length < resto)
                            {
                                sb.Append(sb.ToString());
                            }
                            else
                            {
                                bLoop = false;
                            }
                        }
                        quantityOfA += sb.ToString().Substring(0, (int)resto).ToArray().Count(c => c == A);
                    }

                    result = quantityOfA;
                }
                else {
                    if (s.Length == 1 && s[0] == A) 
                    {
                        return n;
                    }
                }


            }
            return result;

        }

        private static bool IsValidLengthString(string s) 
        {
            return s.Length >= MIN_LENGTH_STRING && s.Length <= MAX_LENGTH_STRING;
        }

        private static bool IsValidQuantityOfLetters(long n)
        {
            return n >= MINQUANTITYOFLETTERS && n <= MAXQUANTITYOFLETTERS;
        }

    }
}
