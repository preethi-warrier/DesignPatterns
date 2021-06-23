using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    interface IAbstractIterator
    {
        Student First();
        Student Next();
        bool IsDone();
    }
}
