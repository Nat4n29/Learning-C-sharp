using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14POO.Entities
{
    internal abstract class Account
    {
        public string Name { get; set; }
        public double YearEarn { get; set; }

        public Account(string name, double yearEarn)
        {
            Name = name;
            YearEarn = yearEarn;
        }

        public abstract double Tax();
    }
}
