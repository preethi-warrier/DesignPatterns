using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}
