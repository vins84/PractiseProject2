using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableCovariance
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            object obj = str;

           
            Console.WriteLine("============     Array  Covariance     ================");
                /* Can cast an array of a derived type to array of the base type */
            var strList = new string[] { "Monday", "Tuesday" };
            object[] objList = strList;
            objList[0] = 5;                     // This will break as the array of string will only allow the object that is a string


                /* This will be possible becasue Enumerable will not allow you to modify the collection */
                /* Covariance is safe for Enumerables because an enumerator will not allow you to modify the colleciton */
                /* covariance is also allowed for IEnumberable<T>, IEnumberator<T>, IReadOnlyCollections<T>, IReadOnlyList<T> */

            var stringList = new List<string> { "Monday", "Tuesday" };
            //List<object> objList = (List<object>)strList;                 // Explicit casting
            IEnumerable<object> objEnum = stringList;


        }
    }
}
