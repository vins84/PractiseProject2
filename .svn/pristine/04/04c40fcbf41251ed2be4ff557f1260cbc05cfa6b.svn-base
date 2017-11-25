using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerateItmes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thrusday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine("==================   DisplayItems    ===================");
            DisplayItems(daysOfWeek);
            DisplayItems("Hello, World");           // Enumeration also works on strings !!!
            Console.WriteLine("==================   DisplayItems2    ===================");
            DisplayItems2(daysOfWeek);

                /* Lines 21 - 25 just for practice. you can see that it wont work as you try to modify the list while you are enumerating through the collection */
                /* However if you try to change the List<string> to string[] it will work.... Why? 
                 * ....Because the compiler would change foreach loop into a for loop behind the scenes which does not implement IEnumerable<T>
                 * meaning that modification is allowed */

            Console.WriteLine("==============   modifying the array while enumerating    =============");
            var days = new string[] { "Monday", "Tuesday", "Wednesday", "Thrusday" };
            foreach (var thing in days)
            {
                days[2] = "2nd day of the week";        
                Console.WriteLine(thing);
            }

        }

         /* Below are two methods used to enumerate through the collection.
          * From obvious reasons second method is much easier but behind the scenes the compiler will still convert foreach loop into a method no.1 (DisplayItems) */
            /* void Reset method takes you to the beginning of the array to Enumerate from the start */
        public static void DisplayItems<T>(IEnumerable<T> collection)
        {
            using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                bool moreItems = enumerator.MoveNext();
                while (moreItems)
                {
                    T items = enumerator.Current;
                    Console.WriteLine(items);
                    moreItems = enumerator.MoveNext();
                }
            }
        }
        
        public static void DisplayItems2<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
