using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Student : Person
    {
        public Student(string nm)
        {
            Name = nm;
        }

        public void Speak()
        {
            Console.Write("Name: " + Name);
        }

        
    }
}
