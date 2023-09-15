using System;
using System.Collections.Generic;

namespace Lesson9POO.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department() { }
        public Department(string name)
        {
            Name = name;
        }
    }
}
