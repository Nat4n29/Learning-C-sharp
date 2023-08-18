using System;
using System.Globalization;

class Sphere
{

    static void Main(string[] args)
    {
        int R;
        double volume, pi = 3.14159;

        R = int.Parse(Console.ReadLine());

        volume = (double)(4 / 3.0) * pi * Math.Pow(R, 3);

        Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
    }

}
