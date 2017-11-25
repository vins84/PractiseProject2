using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnClasses
{
    public class Program
    {  
        static void Main(string[] args) 
        {
            // The use of Destructors on class Dog!
                    /* This can be useful, for example, if your class is working with storage or files. 
                     * The constructor would initialize and open the files. 
                     * Then, when the program ends, the destructor would close the files. */
            
            Dog d = new Dog();

            Dog.Bark();     /* To directly call teh method from the Main the method the method needs to be static ! 
                               **** Note that destructor is called last as anticipated for its functionality(read above) */

            //======================================================================================================================
            // Static method used on class Cat - note that destructor is called last as anticipated for its functionality(read above)
            Cat c1 = new Cat();
            Cat c2 = new Cat();

            Console.WriteLine(Cat.count);

            
            //==================    Some Classes    ================================================================================
            Console.WriteLine(SomeClass.X);
            
            
            //==================    Static Classes  ================================================================================
            Console.WriteLine(Math.Pow(2, 3));

            
            
            //==================       Math         ================================================================================
            
            /*  Math.PI the constant PI.
                Math.E represents the natural logarithmic base e.
                Math.Max() returns the larger of its two arguments.
                Math.Min() returns the smaller of its two arguments.
                Math.Abs() returns the absolute value of its argument.
                Math.Sin() returns the sine of the specified angle.
                Math.Cos() returns the cosine of the specified angle.
                Math.Pow() returns a specified number raised to the specified power.
                Math.Round() rounds the decimal number to its nearest integral value.
                Math.Sqrt() returns the square root of a specified number. */

            //int[] arr = { 1, 2, 3, 4 };

            //Array.Reverse(arr);     //arr = {4, 3, 2, 1}
            //Array.Sort(arr);        //arr = {1, 2, 3, 4}
                
            //string s1 = "some text";
            //string s2 = "another text";

            //String.Concat(s1, s2); // combines the two strings
            //String.Equals(s1, s2); // returns false


            //==============================     The readonly Modifier    ========================================================
            //class Person 
            //{
            //      private readonly string name = "John"; 
            //      public Person(string name) 
            //      {
            //        this.name = name; 
            //      }
            //}

           /* There are three major differences between readonly and const fields. 
              First, a constant field must be initialized when it is declared, whereas a readonly field can be declared without initialization, as in: */

            //readonly string name; // OK
            //const double PI; // Error

           /* Second, a readonly field value can be changed in a constructor, but a constant value cannot.
              Third, the readonly field can be assigned a value that is a result of a calculation, but constants cannot, as in: */

            //readonly double a = Math.Sin(60); // OK
            //const double b = Math.Sin(60); // Error! 

            
            //==============================     Indexer    ========================================================
            Console.WriteLine("====   Indexer   ====");
            string str = "Hello World";
            char x = str[4];
            Console.WriteLine(x);


            Clients c = new Clients();
            c[0] = "Dave";
            c[1] = "Bob";

            Console.WriteLine(c[1]);
            //Outputs "Bob"


            //==============================     Box   -   Operator Overloading   ===================================
            Console.WriteLine("====  Box   -   Operator Overloading  ====");
                    //Box b1 = new Box(14, 3);
                    //Box b2 = new Box(5, 7);
                    //Box b3 = b1 + b2;       // This wont work as the plus(+) sign will not work on those objects unless used operator+

              Box b1 = new Box(14, 3);
              Box b2 = new Box(5, 7);
              Box b3 = b1 + b2;

              Console.WriteLine(b3.Height); //19
              Console.WriteLine(b3.Width); //10



        }
    }
}
