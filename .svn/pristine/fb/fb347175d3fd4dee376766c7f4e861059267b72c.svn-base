using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsEnumsExceptions
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };            // For first example of Enums
        //enum Days { Sun = 7, Mon, Tue, Wed, Thu, Fri, Sat };      // You can also define own enum numbers and then consequtive days will be incremented from Sunday.
        enum TrafficLights { Green, Red, Yellow };


        static void Main(string[] args)
        {
            Book b;
            b.title = "It's my book";
            b.price = 5.99;
            b.author = "David";

            Console.WriteLine("The title of the book is: " + b.title);
            Console.WriteLine("It costs: " + b.price);
            Console.WriteLine("Written by: " + b.author);
            //For some strange reason I cannot put all the variables into a single Console.WriteLine

            //======================================================================================================================

            /* Structs can contain methods, properties, indexers, and so on. 
             * Structs cannot contain default constructors (a constructor without parameters), but they can have constructors that take parameters. 
             * In that case the new keyword is used to instantiate a struct object, similar to class objects */ 

            Point p = new Point(10, 15);
            Console.WriteLine(p.x);
            // Outputs 10
            Console.WriteLine(p.y);

            /* -- Structs vs Classes --
             * In general, classes are used to model more complex behavior, or data, that is intended to be modified after a class object is created. 
             * Structs are best suited for small data structures that contain primarily data that is not intended to be modified after the struct is created. 
             * Consider defining a struct instead of a class if you are trying to represent a simple set of data. */
            //======================================================================================================================
            Console.WriteLine("========================     Enums      =====================================");

            int x = (int)Days.Tue;                      // The Enum declaration is outside the Main
            Console.WriteLine(x);
            //Outputs 2


            TrafficLights z = TrafficLights.Red;        // The Enum declaration is outside the Main
            switch (z)
            {
                case TrafficLights.Green:
                    Console.WriteLine("Go!");
                    break;
                case TrafficLights.Red:
                    Console.WriteLine("Stop!");
                    break;
                case TrafficLights.Yellow:
                    Console.WriteLine("Caution!");
                    break;
            }
            //Outputs "Stop!"

            //======================================================================================================================
            Console.WriteLine("=====================     Exceptions 1      ===================================");
            
            try
            {
                int[] arr = new int[] { 4, 5, 8 };
                Console.Write(arr[8]);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred");         //  My own message
                Console.WriteLine(e.Message);                   //  The original error message (e.Message)
            }
            //Outputs "An error occurred"

            Console.WriteLine("=====================     Exceptions 2      ===================================");

            int w = 12;
            int v = 0;

            try
            {
                int t = w / v;
                Console.WriteLine(t);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error - Cant divide by zero");
            }


            // ===========      Dont really get taht example  -  I do know what is going on but it seems like it meant to give me a different answer     ==============
            //int f;
            //int g;
            //try
            //{
            //    f = Convert.ToInt32(Console.Read());
            //    g = Convert.ToInt32(Console.Read());
            //    Console.WriteLine(f / g);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Cannot divide by 0");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("An error occurred");
            //}

            // ===========      Yet again it didnt really worked    ==============

            //int[] arr = { 2, 5, 3 };
            //int x = 0;
            //try
            //{
            //    x = arr[5];
            //}
            //catch (Exception e)
            //{
            //    x = arr[x];
            //}

            Console.WriteLine("=====================     Exceptions 3      ===================================");

            int result = 0;
            int num1 = 8;
            int num2 = 4;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Calculation Error => Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("The result is : " + result);
            }


        }
    }
}
