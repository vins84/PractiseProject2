using System;

namespace String_Palindrome
{
    class Palindrome
    {
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }


        public static bool IsPalindromeTest(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; ++i, --j)
                if (s[i].ToString().ToUpper() != s[j].ToString().ToUpper())
                {
                    Console.WriteLine("{0} != {1} - not a pelindrome", s[i], s[j]);
                    return false;
                }
            return true;
        }
    }
}
