using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14POO.Entities
{
    internal class CompAccount : Account
    {
        public int Employees { get; set; }

        public CompAccount(string name, double yearEarn, int employees) : base(name, yearEarn)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            double taxe = 0.0;

            if (Employees > 10)
            {
                taxe += YearEarn * 0.14;
            }
            else
            {
                taxe += YearEarn * 0.16;
            }

            return taxe;
        }

        public override string ToString()
        {
            return $"{Name}: $ {Tax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
