using System;

namespace HackerRankTest.Tests
{
    public static class PermutationFunction
    {
        public static void Execute()
        {
            
        }

        public static bool IsPermutation(string a, string b) 
        {
            bool result = true;

            if (a.Length != b.Length)
            {
                result = false;
                return result;
            }

            var aux_a = a.ToCharArray();
            var aux_b = b.ToCharArray();

            Array.Sort(aux_a);
            Array.Sort(aux_b);

            for (int i = 0; i < aux_a.Length; i++)
            {
                if (aux_a[i] != aux_b[i])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
