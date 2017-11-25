using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDependencyForSignOff
{
    public class Book : IBook
    {

        public void GetTitle()
        {
            Console.WriteLine("Pulp Fiction");
        }

        public void GetISBN()
        {
            Console.WriteLine("Book - ISBN");
        }

        public void GetAuthor()
        {
            Console.WriteLine("Quentin Tarrantino");
        }

        public void GetYearOfPublication()
        {
            Console.WriteLine("1990");
        }

        public void GetNumberOfPages()
        {
            Console.WriteLine("197");
        }
    }
}
