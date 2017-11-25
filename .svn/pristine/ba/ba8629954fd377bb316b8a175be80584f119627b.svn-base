using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnClasses
{
    class Person 
    {
        private readonly string name = "John"; 
        public Person(string name) 
        {
        this.name = name; 
        }
    }

        /* There are three major differences between readonly and const fields. 
            First, a constant field must be initialized when it is declared, whereas a readonly field can be declared without initialization, as in: */

        //readonly string name; // OK
        //const double PI; // Error

        /* Second, a readonly field value can be changed in a constructor, but a constant value cannot.
            Third, the readonly field can be assigned a value that is a result of a calculation, but constants cannot, as in: */

        //readonly double a = Math.Sin(60); // OK
        //const double b = Math.Sin(60); // Error! 
}
