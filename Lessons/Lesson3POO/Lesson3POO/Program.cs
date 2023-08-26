using System;
using System.Globalization;

namespace Lesson3POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno:");
            a.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            a.Resultado();
        }
    }
}
