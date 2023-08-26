using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4POO
{
    internal class ConversorDeMoeda
    {
        public static double Conversor(double dolar, double quant)
        {
            double r = dolar * quant;
            return r + (r * 6 / 100);
        }
    }
}
