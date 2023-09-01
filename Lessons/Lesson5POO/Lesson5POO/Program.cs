using System;
using System.Drawing;
using System.Globalization;

namespace Lesson5POO
{
    class Program
    {
        static void Main(string[] args)
        {
            double depoInic;
            double depoValor;
            double saqValor;
            char havera;

            ContaBancaria cb = new ContaBancaria(0000, "NaN", 0.00);

            Console.Write("Entre o número da conta: ");
            int contaNum = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n)? ");
            havera = char.Parse(Console.ReadLine());
            cb = new ContaBancaria(contaNum, nome, cb.Valor);

            if (havera == 's')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                depoInic = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb.DepInic(depoInic);
                cb = new ContaBancaria(cb.ContaNum, cb.Nome, cb.Valor);
            }
            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cb.Dados);
            Console.WriteLine();

            Console.Write("Entre um valor para deposito: ");
            depoValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Deposito(depoValor);
            cb = new ContaBancaria(cb.ContaNum, cb.Nome, cb.Valor);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb.Dados);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            saqValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Saque(saqValor);
            cb = new ContaBancaria(cb.ContaNum, cb.Nome, cb.Valor);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb.Dados);
        }
    }
}