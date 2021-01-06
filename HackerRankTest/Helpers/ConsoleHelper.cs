using System;
using System.Collections.Generic;

namespace HackerRankTest.Helpers
{
    public static class ConsoleHelper
    {
        public static List<OptionItem> Options = new List<OptionItem>();

        public static void ClearScreen() { Console.Clear(); }
        public static void WL(string s) { Console.WriteLine(s); }
        public static void W(string s) { Console.Write(s); }

        public static void Info(string s)
        {
            var fc = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(s);
            }
            finally
            {
                Console.ForegroundColor = fc;
            }
        }

        public static void Debug(string s)
        {
            var fc = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(s);
            }
            finally
            {
                Console.ForegroundColor = fc;
            }
        }

        public static void Error(string s)
        {
            var fc = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: " + s);
            }
            finally
            {
                Console.ForegroundColor = fc;
            }
        }

        public static string GetInput(string message, string defaultValue = "")
        {
            Console.Write(message + (String.IsNullOrEmpty(defaultValue) ? ": " : ", empty to use " + defaultValue + ": "));

            string result = Console.ReadLine();
            return string.IsNullOrEmpty(result) ? defaultValue : result;
        }

        public static long ToLong(this string s)
        {
            return Convert.ToInt64(s);
        }

        public static int ToInt(this string s)
        {
            return Convert.ToInt32(s);
        }

        public static void AddOption(string Description, Action action)
        {
            Options.Add(new OptionItem() { Description = Description, TheAction = action });
        }

        public static void PrintOptions(List<OptionItem> options = null)
        {
            var OptionsList = options ?? Options;
            Console.WriteLine();
            int i = 0;
            foreach (var itm in OptionsList)
            {
                if (i % 5 == 0) WL("");
                WL("   " + i++.ToString() + " - " + itm.Description);
            }

        }

        public static void EnterTheLoop()
        {
            PrintOptions();

            Action selectedAction;
            string s = GetInput("\nChoose Option or press ENTER to finish");
            if (s == string.Empty) return;
            try
            {
                selectedAction = ConsoleHelper.Options[s.ToInt()].TheAction;
            }
            catch
            {
                Error("Invalid option");
                EnterTheLoop();
                return;
            }

            try
            {
                selectedAction();
            }
            catch (Exception e)
            {
                Error(e.ToString());
            }
            EnterTheLoop();
        }

    }
}
