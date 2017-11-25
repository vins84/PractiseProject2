using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindElementsInArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============    Finding Index  ==================");

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int indexOfTuesday = Array.IndexOf(daysOfWeek, "Tuesday");      // Similarly you can use Array.LastIndexOf() to check from the end of the array 

            Console.WriteLine(indexOfTuesday);


            Console.WriteLine("\n==========    Finding Index that satisfies the condition  ===============");
            int indexOfW = Array.FindIndex(daysOfWeek, x => x[0] == 'W');       //NOTE the quotation marks here !!!. Also FindLastIndex() can be used
            Console.WriteLine(indexOfW);
            Console.WriteLine(daysOfWeek[indexOfW]);

            Console.WriteLine("\n==========    Finding All that satisfies the condition    ===============");
            /* This method returns the array of days with 6 characrters */
            /* NOTE - LINQ method can also be used such as Where() to find the strings that satisfies the condition */

            string[] allWith6Char = Array.FindAll(daysOfWeek, x => x.Length == 6);
            foreach (string days in allWith6Char)
            {
                Console.WriteLine(days);
            }

            Console.WriteLine("\n==============     Binary Search      =================");
            /* NOTE - to use binary search the array must be sorted !!! 
             * it must also be realy big otherwise there is no significant improvment over FindIndex() */

            string[] sortedDaysOfWeek = { "Friday", "Monday", "Saturday", "Sunday", "Thursday", "Tuesday", "Wednesday" };
            int indexOfSun = Array.BinarySearch(sortedDaysOfWeek, "Sunday");
            Console.WriteLine("The Index of Sunday is " + indexOfSun);

        }
    }
}
