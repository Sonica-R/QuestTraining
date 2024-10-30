using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public Interface IPrinter
    {
        void Print();
    }

    public Interface IScanner
    {
        void Scan();
    }

    public Interface IFax
    {
        void Fax();
    }

}

