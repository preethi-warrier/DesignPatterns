using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class Iterator : IAbstractIterator
    {
        private ConcreteCollection collection;
        private int current;

        public Iterator(ConcreteCollection _collection)
        {
            collection = _collection;
        }
        public Student First()
        {
            current = 0;
            return collection.GetStudent(current);
        }

        public bool IsDone()
        {
            return current >= collection.Count();
        }

        public Student Next()
        {
            current++;
            if(!IsDone())
            {
                return collection.GetStudent(current);
            }
            return null;
        }
    }
}
