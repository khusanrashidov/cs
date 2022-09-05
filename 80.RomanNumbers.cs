using System;
using System.Collections.Generic;

namespace RomanNumbers
{
    internal static class Program
    {
        static class RomanNumerical
        {
            private static Dictionary<char, int> map = new Dictionary<char, int>(){
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            public static int Parse(string roman)
            {
                int result = 0;
                for (int i = 0; i < roman.Length; i++)
                {
                    if (i + 1 < roman.Length && IsSubtractive(roman[i], roman[i + 1]))
                    {
                        char letter = roman[i];
                        result -= map[letter];
                    }
                    else
                    {
                        result += map[roman[i]];
                    }
                }
                return result;

            }
            public static bool IsSubtractive(char ch1, char ch2)
            {
                return map[ch2] > map[ch1];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RomanNumerical.Parse("VIII"));
        }
    }
}