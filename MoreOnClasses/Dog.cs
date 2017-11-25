using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnClasses
{
    class Dog
    {
        public Dog()
        {
            Console.WriteLine("Constructor");
        }
        ~Dog()
        {
            Console.WriteLine("Destructor");
        }

        
        public static void Bark()
        {
            Console.WriteLine("Woof");
        }
    }
}
