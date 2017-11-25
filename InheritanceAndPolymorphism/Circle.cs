using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Circle : Shape
    {
        public override void Draw()
        {
            // draw a circle...
            Console.WriteLine("Circle Draw");
        }
    }
}
