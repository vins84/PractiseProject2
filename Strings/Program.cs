using System;
using System.Collections.Generic;
using System.Linq;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Jet2_Technical_Test

            var me = 10;
            var too = Convert.ToInt32(me) * Convert.ToInt32(me);
            Console.WriteLine(too);

            //var foo = Console.ReadLine();
            Console.WriteLine("Start");

            double pp = Convert.ToDouble(16.94);
            double ch = Convert.ToDouble(17.00);

            Dictionary<string, double> register = new Dictionary<string, double>();
            register.Add("PENNY", .01);
            register.Add("NICKEL", .05);
            register.Add("DIME", .10);
            register.Add("QUARTER", 0.25);
            register.Add("HHALF DOLLAR", .50);
            register.Add("ONE", 1.00);
            register.Add("TWO", 2.00);
            register.Add("FIVE", 5.00);
            register.Add("TEN", 10.00);
            register.Add("TWENTY", 20.00);
            register.Add("FIFTY", 50.00);
            register.Add("ONE HUNDRED", 100.00);

            var test = new Dictionary<string, double>
                    {
                        { "PENNY", .01 },
                        { "NICKEL", .05},
                        { "DIME", .10}
                    };


            var inputValues = string.Format("{0};{1}", pp, ch);

            var result = ch - pp;
            string coins = "";
            if (result > 0)
            {
                var coinsList = register.Where(w => w.Value <= result).Select(s => s.Key).Reverse().ToList();
                var nearest = register.Where(w => w.Value <= result).Select(s => s.Value).OrderBy(x => Math.Abs(x - result)).First();
                var coinsList2 = register.Where(w => w.Value <= result).Select(s => s.Value).OrderBy(x => Math.Abs(x - result)).ToList();
                //var closest = register.Where(w => w.Value == result).Select(s => s.Key).First();
                //var keys = register.Select(s => s.Value);
                //var diff = keys.Select(i => Math.Abs(i - result)).ToList();
                //var index = diff.IndexOf(diff.Min());

                //var value = register[index].Keys.First();

                //int closest = coinsList.OrderBy(item => Math.Abs(result - item)).First();

                var bestMatch = register.Where(w => w.Value <= result).OrderBy(e => Math.Abs(e.Value - result)).ToList();


                foreach (var coin in bestMatch)
                {
                    coins = coins + coin.Key + ",";
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            var changeInCoins = coins.TrimEnd(',');
            Console.WriteLine(changeInCoins);

            Console.WriteLine(inputValues);

            Console.ReadLine();

            #endregion




            #region MyRegion
            /* String objects support a number of useful properties and methods:
           Length returns the length of the string.
           IndexOf(value) returns the index of the first occurrence of the value within the string.
           Insert(index, value) inserts the value into the string starting from the specified index.
           Remove(index) removes all characters in the string after the specified index.
           Replace(oldValue, newValue) replaces the specified value in the string.
           Substring(index, length) returns a substring of the specified length, starting from the specified index. If length is not specified, the operation continues to the end of the string.
           Contains(value) returns true if the string contains the specified value. */

            //string a = "some text";
            //Console.WriteLine(a.Length);
            ////Outputs 9

            //Console.WriteLine(a.IndexOf('t'));
            ////Outputs 5

            //a = a.Insert(0, "This is ");
            //Console.WriteLine(a);
            ////Outputs "This is some text"

            //a = a.Replace("This is", "I am");
            //Console.WriteLine(a);
            ////Outputs "I am some text"

            //if (a.Contains("some"))
            //    Console.WriteLine("found");
            ////Outputs "found"

            //a = a.Remove(4);
            //Console.WriteLine(a);
            ////Outputs "I am"

            //a = a.Substring(2);
            //Console.WriteLine(a);
            ////Outputs "am"


            ////====================================================================================
            //Console.WriteLine("=============    Replace all occurrences of the word `dog` with `cat`   ==================================");
            //string text = "This is some text about a dog. The word dog appears in this text a number of times. This is the end.";

            //text = text.Replace("dog", "cat");
            //text = text.Substring(0, text.IndexOf(".") + 1);

            //Console.WriteLine(text);
            ////Outputs: "This is some text about a cat."
            #endregion

        }
    }


    public class PP
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public PP(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }






}
