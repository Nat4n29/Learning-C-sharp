using System;
using System.Collections.Generic;

namespace Lesson19POO.Entities
{
    internal class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Student))
            {
                return false;
            }

            Student other = obj as Student;

            return Id.Equals(other.Id);
        }
    }
}
