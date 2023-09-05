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

            ContaBancaria cb = new ContaBancaria();

            Console.Write("Entre o número da conta: ");
            int contaNum = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n)? ");
            havera = char.Parse(Console.ReadLine());
            cb = new ContaBancaria(contaNum, nome, cb.Saldo);

            if (havera == 's' || havera == 'S')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                depoInic = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb.DepInic(depoInic);
                cb = new ContaBancaria(cb.Numero, cb.Titular, cb.Saldo);
            }
            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cb);
            Console.WriteLine();

            Console.Write("Entre um valor para deposito: ");
            depoValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Deposito(depoValor);
            cb = new ContaBancaria(cb.Numero, cb.Titular, cb.Saldo);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            saqValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Saque(saqValor);
            cb = new ContaBancaria(cb.Numero, cb.Titular, cb.Saldo);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb);
        }
    }
}