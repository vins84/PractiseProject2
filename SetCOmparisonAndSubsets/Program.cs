using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCOmparisonAndSubsets
{
    class Program
    {
        static void Main(string[] args)
        {
            //=====================================       Set Comparison and Subsets        ==============================================
                /*ISet<T> Comparison has following functions
                 *      SetEqauls()                     -   Seen below
                 *      IsSubsetof() & IsSupersetOf()   -   Seen here
                 *      Overlaps()                      -   Checks for common strings in two collections
                 *      IsProperSubsetOf()              -   Proper Subset : Subset, excluding the same
                 *      IsProperSupersetOf()            -   Proper Superset : Superset, excluding the same */
                    /* NOTE - Set Comparison does not have LINQ equivalents */

            Console.WriteLine("\n==============     Set Comparison and Subsets    ===================");
            var ukCities = new HashSet<string>               // HashSet gives you the uniqueness !!!
            {
                "Ripon", "Truro", "Manchester", "Leeds"
            };

            var bigUkCities = new HashSet<string>
            {
                "Manchester", "Leeds"
            };

            var bigCitiesArray = new HashSet<string>
            {
                "Leeds", "Paris", "Manchester", "New York"
            };

            //bool ukIsSubset = ukCities.IsSubsetOf(bigCitiesArray);            // IsSubsetOf works great with a List<strings> but not when other collection use HashSet
            bool ukIsSubset = bigCitiesArray.IsSupersetOf(ukCities);                        // IsSupersetOf doesnt work for List<string> if other collection use HashSet
            Console.WriteLine("Is UK Cities a Subset of bigCitiesArray ? " + ukIsSubset);

            //bool bigUkIsSubset = bigUkCities.IsSubsetOf(bigCitiesArray);
            bool bigUkIsSubset = bigCitiesArray.IsSupersetOf(bigUkCities);                  // IsSupersetOf doesnt work for List<string> if other collection use HashSet
            Console.WriteLine("Is bigUkCities a Subset of bigCitiesArray ? " + bigUkIsSubset);

            
            //=====================================     HashSet<T> and Comparer    ==============================================
            Console.WriteLine("\n==============     HashSet<T> with added string Comparer    ===================");

            var famousCars = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)         // or we couldve used (StringComparer.InvariantCultureIgnoreCase) in place of (new UnCasedStringEqualityComparer())  without additional class  UnCasedStringEqualityComparer
            {
                "Opel", "Bmw", "Ford", "Mercedes"
            };

            famousCars.Add("OPEL");
            famousCars.Add("FORD");
            famousCars.Add("BMW");

            foreach (var car in famousCars)
            {
                Console.WriteLine(car);
            }

            //=====================================     HashSet<T> and Array Comparer    ==============================================
            Console.WriteLine("\n==============       HashSet<T> and Array Comparer      ===================");
                /* This compares the values of the arrays. EVen though HashSet assures uniqueness 
                 * it still returned TRUE on line 73 & 74 when comparing if two collections are equal */

            var favourite = new HashSet<string>             // (new UnCasedStringEqualityComparer()) can be used in addition but you need to add the class as seen below and in Dictionary examples
            {
                "Opel", "Bmw", "Ford", "Mercedes"
            };
            var randomCars = new HashSet<string>
            {
                "Dodge", "Maclaren", "Ferrari", "VW"
            };
            var favouriteArray = new string[]
            {
                "Mercedes", "BMW", "Opel", "Ford"
            };

            bool areEqual = favourite.SetEquals(favouriteArray);        // NOTE - favouriteArray order was changed but still returned TRUE
            Console.WriteLine("favourite are equal to favouriteArray ? " + areEqual);

            bool areEqualCars = favourite.SetEquals(randomCars);        // Those two arrays are clearly different so returned FALSE as expected
            Console.WriteLine("favourite are equal to randomCars ? " + areEqualCars);



            //=====================================     Sorted Set    ==============================================

                    /* SortedSet will only work with custom comparer if it implements IComparer<T>. */
                    /* NOTE - it also must use StringComparison and NOT StringComparer as in for HashSet */


            Console.WriteLine("\n==============       Sorted Set      ===================");

            var bigCities = new SortedSet<string>(new UnCasedStringEqualityComparer())               // HashSet gives you the uniqueness !!!
            {                                                                                      // But without custom comparer it will add item in capital letters
                "Manchester", "New York", "Paris", "Leeds"
            };

            bigCities.Add("BEIJING");
            bigCities.Add("PARIS");
            bigCities.Add("MANCHESTER");

            foreach (var city in bigCities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("\n\t Notice that the list is sorted alphabetically");
            
        }
        class UnCasedStringEqualityComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase); 
            }   
        }

    }
}
