using System;
using System.Globalization;

namespace curso
{
    class Lesson2
    {
        static void Main(string[] args)
        {
            double largura, comprimento, valor;

            double area, preco;

            Console.WriteLine("Insira a largura do terreno:");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o comprimento do terreno:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o valor do metro quadrado:");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = valor * area;

            Console.WriteLine("Area do terreno: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço do terreno: " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
