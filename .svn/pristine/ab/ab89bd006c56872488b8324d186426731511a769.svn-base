using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //var daysOfWeek = new List<string>
            //{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};

            //foreach (var day in daysOfWeek)
            //{
            //    Console.WriteLine(day);
            //}


            //====================                ICollection                 ==================================
            //string[] daysOfWeek =
            //{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};

            //ICollection<string> collection = (ICollection<string>)daysOfWeek;
            //Console.WriteLine("Count = " + collection.Count);
            //Console.WriteLine("Length = " + daysOfWeek.Length);         // THis works the same as ICollection<string> becasue we work with array of strings 
            //Console.WriteLine("Count() = " + collection.Count());

            //====================                ICollection  - IsReadOnly               ==================================
            string[] daysOfWeek =
            { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

            ICollection<string> collection = (ICollection<string>)daysOfWeek;

            if (!collection.IsReadOnly)                     /* Needs casting for ADD method to be visible e.g collection.Add("SlaveDay"); will not work */
                    collection.Add("SlaveDay");
            else
                Console.WriteLine("Collection is ReadOnly and cannot add a new item");

            /* But arrays can be modified as below */
            (collection as string[])[5] = "SlaveDay";

            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
