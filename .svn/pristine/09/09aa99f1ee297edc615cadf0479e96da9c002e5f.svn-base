using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingYourOwnEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            AllDaysOfTheWeek allDays = new AllDaysOfTheWeek();

            foreach (var day in allDays)
            {
                Console.WriteLine(day);
            }
        }
    }

    public class AllDaysOfTheWeek : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            Console.WriteLine("Calling generic GetEnumerator()");
            yield return "Monday";
            yield return "Tuesday";
            yield return "Wednesday";
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
