using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCollection coll = new ConcreteCollection();
            coll.Add(new Student(1, "Sam"));
            coll.Add(new Student(2, "Bucky"));
            coll.Add(new Student(3, "Peter"));

            var iterator = coll.GetIterator();
            for(var s = iterator.First(); !iterator.IsDone();s= iterator.Next())
            {
                Console.WriteLine(s.Id);
                Console.WriteLine(s.Name);
            }
        }
    }
}
