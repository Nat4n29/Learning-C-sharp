using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization;
using URI_beecrowd;

class Program
{

    static void Main(string[] args)
    {
        double media;

        Identification name = new Identification();
        Identification salary = new Identification();

        Console.WriteLine("Dados da primeira pessoa:");
        name.name1 = Console.ReadLine();
        salary.salary1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Dados da segunda pessoa:");
        name.name2 = Console.ReadLine();
        salary.salary2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = (salary.salary1 + salary.salary2) / 2;

        Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
    }

}
