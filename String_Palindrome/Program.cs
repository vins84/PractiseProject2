using System;

namespace String_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            //string _Inputstr = string.Empty;
            //string _Reversestr = string.Empty;

            //Console.Write("Enter the string : ");
            //_Inputstr = Console.ReadLine();
            //Console.WriteLine("{0}", _Inputstr.Length - 1);

            //for (int i = _Inputstr.Length - 1; i >= 0; i--)
            //{
            //    _Reversestr += _Inputstr[i];
            //}
            //Console.WriteLine("The reverse string is {0}", _Reversestr);
            //Console.ReadLine();


            //=================     2nd Method      ======================
            //string _inputstr = string.Empty;
            //string _reversestr = string.Empty;

            //Console.Write("Enter a string : ");
            //_inputstr = Console.ReadLine();

            //if (_inputstr != null)
            //{
            //    for (int i = _inputstr.Length - 1; i >= 0; i--)
            //    {
            //        _reversestr += _inputstr[i].ToString();
            //    }
            //    if (_reversestr == _inputstr)
            //    {
            //        Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
            //    }
            //    else
            //    {
            //        Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
            //    }
            //}
            //Console.ReadLine();


            //=================     3rd Method      ======================
            //string _inputstr22 = string.Empty;
            //string _reversestr22 = string.Empty;

            //Console.Write("Enter a string : ");
            //_inputstr22 = Console.ReadLine();

            //for (int i = 0; i < _inputstr22.Length / 2; i++)
            //{
            //    _reversestr22 += _inputstr22[i].ToString();

            //    if (_inputstr22[i] != _inputstr22[_inputstr22.Length - i - 1])
            //        Console.WriteLine("Input = {0} and Output= {1}", _inputstr22, _reversestr22);
            //}

            //Console.WriteLine("{0}", _reversestr22);
            //Console.ReadLine();



            //=================     4th Method      ======================
            #region Input Array
            string[] array =
            {
                "civic",
                "deified",
                "deleveled",
                "devoved",
                "dewed",
                "Hannah",
                "kayak",
                "level",
                "madam",
                "racecar",
                "radar",
                "redder",
                "refer",
                "repaper",
                "reviver",
                "rotator",
                "rotor",
                "sagas",
                "solos",
                "sexes",
                "stats",
                "tenet",

                "Dot",
                "Net",
                "Perls",
                "Is",
                "Not",
                "A",
                "Palindrome",
                ""
            };
            #endregion

            foreach (string value in array)
            {
                Console.WriteLine("{0} = {1}", value, Palindrome.IsPalindrome(value));
                Console.WriteLine("{0} = {1}", value, Palindrome.IsPalindromeTest(value));
                Console.WriteLine("{0} = {1}", value, IsPalindrome(value));

            }
            Console.ReadLine();



        }


        public static bool IsPalindrome(string value)
        {
            if (value == null)
                return false;

            if (value.Length == 0)
                return true;

            Func<string, int, int, bool> ip = null;
            ip = (v, sc, ec) =>
            {
                if (v[sc] != v[ec])
                {
                    //first index != last index
                    //Console.WriteLine("Damn");
                    return false;
                }
                if (sc >= ec)
                {
                    //Console.WriteLine("Damn");

                    return true;
                }
                // Console.WriteLine("OK");

                return ip(v, sc + 1, ec - 1);
            };
            //Console.WriteLine("OK2");

            return ip(value, 0, value.Length - 1);
        }


        //Tests
        //public static bool IsPalindrome(string text)
        //{
        //    return isPalindrome(0, text.Length - 1, text);
        //}

        //private static bool isPalindrome(int indexOfFirst, int indexOfLast, string text)
        //{
        //    if (indexOfFirst >= indexOfLast)
        //        return true;

        //    if (text[indexOfFirst] != text[indexOfLast])
        //        return false;

        //    return isPalindrome(indexOfFirst + 1, indexOfLast - 1, text);
        //}


    }

}
