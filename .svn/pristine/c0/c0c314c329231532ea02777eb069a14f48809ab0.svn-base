using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {

           /* String objects support a number of useful properties and methods:
            Length returns the length of the string.
            IndexOf(value) returns the index of the first occurrence of the value within the string.
            Insert(index, value) inserts the value into the string starting from the specified index.
            Remove(index) removes all characters in the string after the specified index.
            Replace(oldValue, newValue) replaces the specified value in the string.
            Substring(index, length) returns a substring of the specified length, starting from the specified index. If length is not specified, the operation continues to the end of the string.
            Contains(value) returns true if the string contains the specified value. */

            string a = "some text";
            Console.WriteLine(a.Length);
            //Outputs 9

            Console.WriteLine(a.IndexOf('t'));
            //Outputs 5

            a = a.Insert(0, "This is ");
            Console.WriteLine(a);
            //Outputs "This is some text"

            a = a.Replace("This is", "I am");
            Console.WriteLine(a);
            //Outputs "I am some text"

            if (a.Contains("some"))
                Console.WriteLine("found");
            //Outputs "found"

            a = a.Remove(4);
            Console.WriteLine(a);
            //Outputs "I am"

            a = a.Substring(2);
            Console.WriteLine(a);
            //Outputs "am"


            //====================================================================================
            Console.WriteLine("=============    Replace all occurrences of the word `dog` with `cat`   ==================================");
            string text = "This is some text about a dog. The word dog appears in this text a number of times. This is the end.";

            text = text.Replace("dog", "cat");
            text = text.Substring(0, text.IndexOf(".") + 1);

            Console.WriteLine(text);
            //Outputs: "This is some text about a cat."
        }
    }
}
