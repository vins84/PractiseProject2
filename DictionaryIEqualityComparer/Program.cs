using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;       //Needed for ReadOnlyDictionary

namespace DictionaryIEqualityComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            // =============================     IEquality  Comparer      ==================================
            /* Compares the strings but ignores the case */

            //var primeMinisters = new SortedDictionary<string, PrimeMinister>(StringComparer.InvariantCultureIgnoreCase)
            //{
            //    {"JC", new PrimeMinister("James Callasghan", 1976)},
            //    {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
            //    {"TB", new PrimeMinister("Tony Blair", 1997)}
            //};

            //Console.WriteLine(primeMinisters["tb"]);



            /* ==========================     The below uses my custom comparer   !!!!  ===============================  */

            //var primeMinisters = new Dictionary<string, PrimeMinister>(new UnCasedStringEqualityComparer())
            //{
            //    {"JC", new PrimeMinister("James Callasghan", 1976)},
            //    {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
            //    {"TB", new PrimeMinister("Tony Blair", 1997)}
            //};

            //Console.WriteLine(primeMinisters["tb"]);

            //Console.WriteLine("\n===============    ReadOnlyDictionary    ============== ");

            //var pmsReadOnly = new ReadOnlyDictionary<string, PrimeMinister>(primeMinisters);

            //foreach (var pm in pmsReadOnly)
            //{
            //    Console.WriteLine(pm.Value);
            //}


            /* =========================       Sorted Dictionary       ============================  */

            var primeMinisters = new SortedList<string, PrimeMinister>              // or you can use SortedDictionary  -->  Essentially functionality is the same. 
                                                                                    /* the difference is in a data structure i.e Balance Tree. It is recommended to use Sorted Dict if frequently needs changing  */
            {
                {"JC", new PrimeMinister("James Callasghan", 1976)},
                {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony Blair", 1997)}
            };

            primeMinisters.Add("JM", new PrimeMinister("James Major", 1990));

            foreach (var pm in primeMinisters)
            {
                Console.WriteLine(pm.Value);
            }
            Console.WriteLine("\ntony is" + primeMinisters["TB"]);
        }

        /* But imagine if there was no predefined method to compare the string ..... we would need to specify our own string comparer as below ! */

        class UnCasedStringEqualityComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y)
            {
                return x.ToUpper() == y.ToUpper();      //Checks whether the strings are equal ignoring the case 
            }
            public int GetHashCode(string obj)
            {
                return obj.ToUpper().GetHashCode();
            }
        }
    }
}
