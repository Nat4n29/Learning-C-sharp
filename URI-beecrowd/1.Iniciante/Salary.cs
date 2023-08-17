using System;
using System.Globalization;

class Salary
{

    static void Main(string[] args)
    {

        int numFunc, hrsTra;
        double valorhrs, salario;

        numFunc = int.Parse(Console.ReadLine());
        hrsTra = int.Parse(Console.ReadLine());
        valorhrs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salario = valorhrs * hrsTra;

        Console.WriteLine("NUMBER = " + numFunc);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

    }

}
