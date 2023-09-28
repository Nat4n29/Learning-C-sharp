using Lesson13POO.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13POO.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
        }
        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override string ToString()
        {
            return Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
