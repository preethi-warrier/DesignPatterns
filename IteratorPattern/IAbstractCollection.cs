using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public interface IAbstractCollection
    {
        public Iterator GetIterator();        
    }
}
