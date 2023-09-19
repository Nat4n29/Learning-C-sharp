using System.Text;

namespace Lesson11POO.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        virtual public double Payment()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
