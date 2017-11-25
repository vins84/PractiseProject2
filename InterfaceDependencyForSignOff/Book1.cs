using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDependencyForSignOff
{
    public class Book1 : IBook
    {
        public void GetTitle()
        {
            Console.WriteLine("\nStar Trek");
        }

        public void GetISBN()
        {
            Console.WriteLine("Book1 - ISBN");
        }

        public void GetAuthor()
        {
            Console.WriteLine("Gene Roddenberry");
        }
    }
}
