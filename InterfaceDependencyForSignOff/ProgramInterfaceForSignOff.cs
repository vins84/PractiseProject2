using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDependencyForSignOff
{
    class ProgramInterfaceForSignOff
    {
        static void Main(string[] args)
        {

            Book book = new Book();
            book.GetTitle(); book.GetISBN(); book.GetAuthor(); book.GetYearOfPublication(); book.GetNumberOfPages();

            Book1 book1 = new Book1();
            book1.GetTitle(); book1.GetISBN(); book1.GetAuthor();

            Book2 book2 = new Book2();
            book2.GetTitle(); book2.GetISBN(); book2.GetAuthor();

            Console.WriteLine("\n------ Now, instantiating an ibook object referencing an Interface -----------");
                    /* It can be seen that even though Book is instantiated it cannot see the extra methods that Book (above) has...
                       i.e. it cannot see GetYearOfPublication() & GetNumberOfPages() as they only belong to Book Class thus, not implemented by IBook Interface*/
            IBook ibook = new Book();
            ibook.GetTitle();
            ibook.GetISBN();
            ibook.GetAuthor();

            ibook = new Book1();
            ibook.GetTitle();
            ibook.GetISBN();
            ibook.GetAuthor();

            ibook = new Book2();
            ibook.GetTitle();
            ibook.GetISBN();
            ibook.GetAuthor();

            

        }
    }
}
