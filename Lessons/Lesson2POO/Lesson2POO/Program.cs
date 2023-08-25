using System;
using System.Globalization;

namespace Lesson2POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + f.Nome + ", $ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
            
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double prct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(prct);

            Console.WriteLine("Dados atualizados: " + f.Nome + ", $ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}