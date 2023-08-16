using System;
using System.Globalization;

class Media2
{

    static void Main(string[] args)
    {

        double A = 2, B = 3, C = 5, valor1, valor2, valor3, media;

        valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = ((valor1 * A) + (valor2 * B) + (valor3 * C)) / (A + B + C);

        Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

    }

}
