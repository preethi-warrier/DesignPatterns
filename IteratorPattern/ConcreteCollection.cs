using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class ConcreteCollection : IAbstractCollection
    {
        List<Student> studentCollection = new List<Student>();
        public Iterator GetIterator()
        {
            return new Iterator(this);
        }

        public void Add(Student stu)
        {
            studentCollection.Add(stu);
        }

        public int Count()
        {
            return studentCollection.Count;
        }

        public Student GetStudent(int index)
        {
            if (index < studentCollection.Count)
            {
                return studentCollection[index];
            }
            return null;
        }
    }
}
