using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArraysAndIComparerT
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Array.Sort(daysOfWeek);
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);         // Bingo sorted alphabetiaclly
            }

            Console.WriteLine("\n=======    Sorting by the length of the string   =========");
            var comparer = new StringLengthComparer();
            Array.Sort(daysOfWeek, comparer);
            foreach (string item in daysOfWeek)
            {
                Console.WriteLine(item);
            }
        }

    }
    class StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
}
