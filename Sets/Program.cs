using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Stack does not store any keyValue or IndexValue jsut the field value i.e. just the name */
            /* if string[] used then cannot use add method and IntersectWith doesnt work but....LINQ still works fine */

            var bigCities = new HashSet<string>               // HashSet gives you the uniqueness !!!
            {
                "Manchester", "New York", "Paris", "Leeds"
            };

            //if (!bigCities.Contains("Manchester"))          // This wokrs perfect for list but for sets it is very inefficient
            //{
            //    bigCities.Add("Manchester");
            //}

            bigCities.Add("Manchester");        // Notice that Mancheser was not duplicated. This was achieved by using HashSet!!!
            bigCities.Add("Beijing");

            bool addedWarsawa = bigCities.Add("Warsawa");
            bool addedNewYork = bigCities.Add("New York");
            Console.WriteLine("\r\tAdded Warsawa : " + addedWarsawa);
            Console.WriteLine("\r\tAdded New York : " + addedNewYork);


            foreach (var city in bigCities)
            {
                Console.WriteLine(city);
            }

            

            //================================================================================================================================
            var worldBigCities = new HashSet<string>               // HashSet gives you the uniqueness !!!
            {
                "Manchester", "New York", "Paris", "Leeds"
            };
            //=====================================       Intersection and IntersectWith        ==============================================
            Console.WriteLine("\n==============     Intersection and IntersectWith     ===================");
            string[] citiesInUk =
            {
                "Ripon", "Truro", "Manchester", "Leeds"
            };

            worldBigCities.IntersectWith(citiesInUk);
            foreach (var city in worldBigCities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("\n==============     Intersection using LINQ Method     ===================");
                                            /* LINQ might not work on HashSets !!!! */
                                            /* LINQ also have Union() and Except() but not SymmetricExceptWith() - try them out to see how it works */
            var newCities = worldBigCities.Intersect(citiesInUk);
            var newerCities = bigCities.Union(citiesInUk);              // uses bigCities
            var newestCities = bigCities.Except(citiesInUk);            // uses bigCities
            foreach (var city in newestCities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("\n==============     UnionWith     ===================");
                                        /* NOTE - This uses bigCities. */
            bigCities.UnionWith(citiesInUk);
            foreach (var city in bigCities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("\n==============     Symmetric Difference     ===================");
            /* This uses bigCities. Symmetric difference looks for items in collections that are not repeated in another collection*/
            /* Remember to use original arrays and not the one already modified i.e. bigCities was modified by UnionWith !!! 
             * Comment UnionWith and see how it works */

            bigCities.SymmetricExceptWith(citiesInUk);
            foreach (var city in bigCities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("\n==============     Difference     ===================");
            /* This uses bigCities. Difference gives you values that are in a first collection but not in the second */
            /* Remember to use original arrays and not the one already modified i.e. bigCities was modified by UnionWith and SymmetricDifference!!! 
             * Comment SymmetricDifference and UnionWith and see how it works */

            bigCities.ExceptWith(citiesInUk);
            foreach (var city in bigCities)
            {
                Console.WriteLine(city);
            }
        }

        
    }
}
