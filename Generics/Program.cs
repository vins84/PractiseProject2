using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            //T temp = a;
            //a = b;
            //b = temp;
        }

        static void Main(string[] args)
        {
            int a = 4, b = 9;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a+" "+b);
            
            string x = "Hello";
            string y = "World";
            Swap<string>(ref x, ref y);
            Console.WriteLine(x+" "+y);

            //=============================================================================================================================
            Console.WriteLine("==================       Generic Classes        =======================");

            Stack<int> intStack = new Stack<int>();
            intStack.Push(3);
            intStack.Push(6);
            intStack.Push(7);

            Console.WriteLine(intStack.Get(1));
            //Outputs 6

        }

        //static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}

        //static void Swap<T>(ref T a, ref T b)
        //{
        //    T temp = a;
        //    a = b;
        //    b = temp;
        //    Console.WriteLine(temp);
        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //}


        //===============================  This is JUST an example of a function with two variables swap !!   =============================
        
        //static void Func<T, U> (T x, U y)
        //{
        //    Console.WriteLine(x + " " + y);
        //}
        //static void Main(string[] args)
        //{
        //    double x = 7.42;
        //    string y = "test";
        //    Func(x, y);
        //}
        


    }
}
