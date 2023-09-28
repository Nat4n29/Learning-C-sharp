using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14POO.Entities
{
    internal class IndAccount : Account
    {
        public double HearthExpend { get; set; }

        public IndAccount(double hearthExpend, string name, double yearEarn) : base(name, yearEarn)
        {
            HearthExpend = hearthExpend;
        }

        public override double Tax()
        {
            double taxe = 0.0;

            if(YearEarn < 20000.00)
            {
                taxe += YearEarn * 0.15;

                if(HearthExpend > 0)
                {
                    taxe -= HearthExpend * 0.5;
                }
            }
            else
            {
                taxe += YearEarn * 0.25;
                if (HearthExpend > 0)
                {
                    taxe -= HearthExpend * 0.5;
                }
            }

            return taxe;
        }

        public override string ToString()
        {
            return $"{Name}: $ {Tax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
