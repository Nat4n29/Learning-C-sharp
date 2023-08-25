using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1POO
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double area = Largura * Altura;
            return area;
        }

        public double Perimetro()
        {
            double peri = (Altura + Largura) * 2;
            return peri;
        }

        public double Diagonal()
        {
            double hipo = Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
            return hipo;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
