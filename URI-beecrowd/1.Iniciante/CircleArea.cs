using System;
using System.Globalization;

class CircleArea
{

    static void Main(string[] args)
    {

        double area, raio, n;

        n = 3.14159;

        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        area = Math.Pow(raio, 2) * n;

        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

    }

}
