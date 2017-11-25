using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDependencyForSignOff
{
    public class Book2 : IBook
    {
        public void GetTitle()
        {
            Console.WriteLine("\nNatural Born Killers");
        }

        public void GetISBN()
        {
            Console.WriteLine("Book2 - ISBN");
        }

        public void GetAuthor()
        {
            Console.WriteLine("Oliver Stone");
        }

    }
}
