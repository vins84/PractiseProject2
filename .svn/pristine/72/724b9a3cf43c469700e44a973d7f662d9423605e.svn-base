using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();

            Console.WriteLine("How many legs dog have: ?");
            Console.WriteLine(d.Legs);
            d.LegNo();
            d.Bark();

            //==============================================================================================
            Console.WriteLine(" =============   Protected  modifier  =================");

            Student s = new Student("David");
            s.Speak();

            //s.Name = "Bob";             // This will not compile due to a protected base class

            //==============================================================================================
            Console.WriteLine("\n ** NOTE**  That destructors are call last thus, dog and animal deleted appears at the end of the console app **");
            /* Note that the base class constructor is called first and the derived class constructor is called next.
               When the object is destroyed, the derived class destructor is invoked and then the base class destructor is invoked. */

            Duck duck = new Duck();
            
            //==============================================================================================
            Console.WriteLine(" =============      Polymorphism      =================");

            Shape c = new Circle();
            c.Draw();
            //Outputs "Circle Draw"

            Shape r = new Rectangle();
            r.Draw();
            //Outputs "Rect Draw"

            /* Polymorphism can be useful in many cases. 
             * For example, we could create a game where we would have different Player types with each Player having a separate behavior for the Attack method. 
               In this case, Attack would be a virtual method of the base class Player and each derived class would override it. */

            //==============================================================================================

            Structure t = new Triangle();
            t.Sketch();

            Structure p = new Rombus();
            p.Sketch();

            /*  Abstract classes have the following features:
                - An abstract class cannot be instantiated.
                - An abstract class may contain abstract methods and accessors.
                - A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors. */


        }
    }
}
