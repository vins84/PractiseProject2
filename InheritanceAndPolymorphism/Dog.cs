using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Dog : Animal
    {
        public Dog()
        {
            Legs = 4;
        }

        public void Bark()
        {
            Console.WriteLine("Woof");
        }

        public void LegNo()
        {
            Console.WriteLine("The dog has No. of legs: " + Legs);
        }


        
    }
}
