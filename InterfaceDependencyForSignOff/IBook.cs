using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDependencyForSignOff
{
    interface IBook
    {
        void GetTitle();

        void GetISBN();

        void GetAuthor();
    }
}
