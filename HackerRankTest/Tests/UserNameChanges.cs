namespace HackerRankTest.Tests
{
    public static class UserNameChanges
    {
        private static string Interchange(string value, int positionFrom, int positionTo)
        {
            string result = string.Empty;
            var char1 = value[positionFrom];
            var char2 = value[positionTo];

            for (int i = 0; i < value.Length; i++)
            {
                if (i == positionFrom)
                {
                    result += char2;
                }
                else {
                    if (i == positionTo)
                    {
                        result += char1;
                    }
                    else
                    {
                        result += value[i];
                    }
                }
            }
            return result;
        }

        public static void Execute() 
        {
            var result = Interchange("CAMELLO", 1, 3);
            System.Console.WriteLine(result);
        }
    }
}
