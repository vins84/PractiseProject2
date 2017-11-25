using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            /* NOTE - Arrays operations can use LINQ but remember to add the using System.LINQ */

            Console.WriteLine("===============    Copying the Array   ==================");
            int[] squares = { 2, 4, 9, 16 };

            int[] copyOfSquares = new int[8];
            squares.CopyTo(copyOfSquares, 2);       //Copying squares[] into copyOfSquares. Parameter 0 specifies index destination to start copying the array.

            foreach (int value in copyOfSquares)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(string.Format("Is squares == copyOfSquares {0} ", squares == copyOfSquares));     // THis returns FALSE correctly as both array refere to different allocated memory event tho it happends that they have the same values.


            /* If you require some flexibility of which elelments to copy to a new array you can use Array.Copy */
            /* Althouhg, LINQ can also be used to copy an array but without flexibility of which elements to copy */
            Console.WriteLine("\n=======   LINQ method of copying the arrays    =======");

            int[] copy = squares.ToArray();
            foreach (var item in copy)
            {
                Console.WriteLine(item);
            }

            //=================      Reversing the Array   ========================
            Console.WriteLine("\n============    Reversing the Array   =================");

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Array.Reverse(daysOfWeek);
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            // but we if not careful you can make a mistake like this...
            //daysOfWeek.Reverse();       //Telesense picked  up an extension method reverse which is of Enumerable.Reverse(this IEnumerable)  -> it wont work as it is

            // To get it to work one must use LINQ
            Console.WriteLine("\n=========     Reverse LINQ Method   ==========");

            string[] daysOfWeek222 = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            var reversed = daysOfWeek222.Reverse();        //extension Reverse is an a static method so new variable must be initiated 
                // NOTE - the above line do not copy the array but creates a new Enumerable colleciton
                // But is you do..... var reversed = daysOfWeek222.Reverse().ToArray(); and hover over the var you d see that now it is an array of strings -> Huray :)  
            foreach (string day in reversed)
            {
                Console.WriteLine(day);
            }


        }
    }
}
