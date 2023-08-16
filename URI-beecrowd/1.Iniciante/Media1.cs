using System;
using System.Globalization;

class Media1
{

    static void Main(string[] args)
    {

        double A = 3.5, B = 7.5, valor1, valor2, media;

        valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = ((valor1 * A) + (valor2 * B)) / (A + B);

        Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

    }

}
