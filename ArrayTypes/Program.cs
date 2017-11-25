using System;
using System.Windows.Forms;

namespace ArrayTypes
{
    class Program
    {
        static void Main(string[] args)
        {
                        /* Arrays are reference types. The same as all collections in C# */
                
            int[] x1 = { 1, 4, 9, 16 };
            var x2 = x1;

            int[] x3 = { 1, 4, 9, 16 };

            Console.WriteLine(string.Format("x1 == x2 is {0}", x1 == x2));  //This returns TRUE becasue it compares the references i.e pointers
            Console.WriteLine(string.Format("x1 == x3 is {0}", x1 == x3));  //Thus this will return FALSE as it is not the same reference

            
            //========================     Storing Derived Instances in Array     =============================
            Console.WriteLine("\n==============     Storing Derived Instances in Array     ==================");
            object[] objArray = new object[3]
                {
                    "Hello World", 4, new Button {Text = "Click Me" }
                };

            Type objArrayType = objArray.GetType();     // Put the breakpoint at foreach and see that Base type is System.Array.... Object[] -> Array -> object

            string[] strArray = new string[2];          // The same is here.  string[] -> Array -> object
            Type strArrayType = strArray.GetType();

            foreach (var item in objArray)
            {
                Console.WriteLine(item);
            }

            
            //========================     Array Coviarance     =============================
            Console.WriteLine("\n==============     Array Coviarance     ==================");

            object[] objArrayTest = new object[2];
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            object[] objArrayTest2 = daysOfWeek;        // Here we implicitly cast Derived[] to Base[] ...This is Array Coviarance
           
            foreach (var item in objArrayTest2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n==============================================================");
            /* objArrayTest is an array of object so anything can be stored in it. 
             * so...lets set the first element of that array to an integer....... this will work fine. */
            objArrayTest[0] = 2;
            Console.WriteLine("objArrayTest[0] = " + objArrayTest[0]);

            /* but lets set integer as the first element for objArrayTest2 (which holds the strings) */
            /* You will notice that it crashes becasue even though the compiler thinks objArrayTest2 refers to an array of objects it actually refers to an array of string ( daysOfWeek ) */
            objArrayTest2[0] = 1;
            Console.WriteLine("objArrayTest2[0] = " + objArrayTest2[0]);

            /* Above no error was detected by the compiler, however if you say......daysOfWeek[0] = 1, the compiler will notice the mistake straight away */
            //daysOfWeek[0] = 1;      // This way we converted Array conviarance from compile-time error into a run-time error
                

        }
    }
}
