using System;
using System.Globalization;

class SalaryWithBonus
{

    static void Main(string[] args)
    {

        string nome;
        double salario, venda, total;

        nome = Console.ReadLine();
        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        venda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        total = salario + venda * (15d / 100d);

        Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

    }

}
