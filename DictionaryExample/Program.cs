using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //==============  Initial Dictionary ==========================
            // This example isnt used anywhere. It is here to show how to instatiate dictianary
            //Dictionary<string, double> register = new Dictionary<string, double>();
            //register.Add("PENNY", .01);
            //register.Add("NICKEL", .05);
            //register.Add("DIME", .10);
            //register.Add("QUARTER", 0.25);
            //register.Add("HHALF DOLLAR", .50);
            //register.Add("ONE", 1.00);
            //register.Add("TWO", 2.00);
            //register.Add("FIVE", 5.00);
            //register.Add("TEN", 10.00);
            //register.Add("TWENTY", 20.00);
            //register.Add("FIFTY", 50.00);
            //register.Add("ONE HUNDRED", 100.00);

            //var test = new Dictionary<string, double>
            //        {
            //            { "PENNY", .01 },
            //            { "NICKEL", .05},
            //            { "DIME", .10}
            //        };


            //With C# 6.0, you can create a dictionary in following way:
            //var dict = new Dictionary<string, int>
            //{
            //    ["one"] = 1,
            //    ["two"] = 2,
            //    ["three"] = 3
            //};


            //==============  Initial List Setup ==========================
            //var primeMinister = new List<PrimeMinister>
            //{
            //    new PrimeMinister("James Callasghan", 1976),
            //    new PrimeMinister("Margaret Thatcher", 1979),
            //    new PrimeMinister("Tony Blair", 1997)                
            //};

            //foreach (var pm in primeMinister)
            //{
            //    Console.WriteLine(pm);
            //}


            //=============   Now Setup for Dictionaries    =================

            /* In this example we ll be looking up initials of Prime Ministers by string 
             * although, it is to be noted that we can similarly search by the year they were elected */
            //var primeMinisters = new SortedDictionary<string, PrimeMinister>
            //{
            //    {"JC", new PrimeMinister("James Callasghan", 1976)},
            //    {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
            //    {"TB", new PrimeMinister("Tony Blair", 1997)}
            //};

            /* use primeMinister.Values or .Key to display desired values. Very nice feature.
               OR you can enumerate the Key or a Value by using Console.WriteLine(pm.Key + ",     " + pm.Value); */

            //foreach (var pm in primeMinisters)     
            //{
            //    Console.WriteLine(pm.Key + ",     " + pm.Value);
            //}


            // ===============  Looking up a Dictionary by string!!!!  ================

            //PrimeMinister pm = primeMinisters["TB"];
            //Console.WriteLine("value is: " + pm.ToString() + "\r\n");

            /* Important - if you searching for non-existing entry in a dictionary,
             * it is important to catch the error using the following code: */

            //PrimeMinister pm;
            //bool found = primeMinisters.TryGetValue("DC", out pm);
            //if (found)
            //{
            //    Console.WriteLine("value is: " + pm.ToString() + "\r\n");
            //}
            //else
            //{
            //    Console.WriteLine("The value of `DC` was not found");
            //}


            // ===============  Looking up a Dictionary by string!!!!  ================
            //var primeMinisters = new Dictionary<int, PrimeMinister>
            //{
            //    {1976, new PrimeMinister("James Callasghan", 1976)},
            //    {1979, new PrimeMinister("Margaret Thatcher", 1979)},
            //    {1997, new PrimeMinister("Tony Blair", 1997)}
            //};
            //PrimeMinister pm;
            //bool found = primeMinisters.TryGetValue(1979, out pm);
            //if (found)
            //{
            //    Console.WriteLine("value is: " + pm.ToString() + "\r\n");
            //}
            //else
            //{
            //    Console.WriteLine("The value of `DC` was not found");
            //}

            // ===============  Looking up a Dictionary by string!!!!  ( KEYED COLLECTION ) ================
            /* It is particularly useful if needed to look up by the election date ( NOTE* the KEY needs to be unique otherwise dictionaries wont work) */

            var primeMinisters = new PrimeMinisterByYearDictionary()
            {
                new PrimeMinister("James Callasghan", 1976),
                new PrimeMinister("Margaret Thatcher", 1979),
                new PrimeMinister("Tony Blair", 1997)
            };

            primeMinisters.Add(new PrimeMinister("John Major", 1990));

            var list = (IList<PrimeMinister>)primeMinisters;        /* This works because we have casted the list of primeMinisters into an IList */
            Console.WriteLine("The First PM is: " + list[0]);       /* so now it s possible to look up first PM by index [0] and not by the key
                                                                       This is only useful if the key and is an int otherwise casting to IList is unnecessary */
            Console.WriteLine("Example of keyed dictionary");
            Console.WriteLine("tony is  " + primeMinisters[1997]);
            Console.WriteLine();
            foreach (var pm in primeMinisters)
            {
                Console.WriteLine(pm);
            }
        }

            class PrimeMinisterByYearDictionary : KeyedCollection<int, PrimeMinister>       //using System.Collections.ObjectModel
            {
                protected override int GetKeyForItem(PrimeMinister item)
                {
                    return item.YearElected;
                }
            }

            // ==========  Updating the entries in a Dictionary   ============

            //primeMinisters["JC"] = new PrimeMinister("Jim Callaghan", 1976);

            //primeMinisters["JM"] = new PrimeMinister("John Major", 1990);

            //primeMinisters.Add("GB", new PrimeMinister("Gordon Brown", 2007));

                            /* As you ve noticed both JM and GB were added to the dictionary. One by using an indexer and the other by using Add method.
                             * The Difference is that Add method will not allow you to add an existing entry i.e. it will throw an exeption.
                             * In addition, for Add method the key must be specified */

            //foreach (var pm in primeMinisters)
            //{
            //    Console.WriteLine(pm.Key + ",     " + pm.Value);
            //}

            
            // ==========   Removing the entry from a dictionary  =============
            
            //primeMinisters.Remove("JC");
            
            //foreach (var pm in primeMinisters)
            //{
            //    Console.WriteLine(pm.Key + ",     " + pm.Value);
            //}


        }
    }
