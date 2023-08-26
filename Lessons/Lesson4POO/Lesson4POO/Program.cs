using System;
using System.Globalization;

namespace Lesson4POO
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, quantidade;

            Console.Write("Qual é a cotação do dólar? ");
            dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Conversor(dolar, quantidade).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}