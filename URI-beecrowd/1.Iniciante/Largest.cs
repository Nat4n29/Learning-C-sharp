using System;
using System.Globalization;

class Largest
{

    static void Main(string[] args)
    {
        int value, result, hundred, fity, twenty, ten, five, two, one;

        result = int.Parse(Console.ReadLine());

        hundred = result / 100;
        value = result - hundred * 100;

        fity = value / 50;
        value = value - fity * 50;

        twenty = value / 20;
        value = value - twenty * 20;

        ten = value / 10;
        value = value - ten * 10;

        five = value / 5;
        value = value - five * 5;

        two = value / 2;
        value = value - two * 2;

        one = value / 1;
        value = value - one * 1;

        Console.WriteLine(result);
        Console.WriteLine(hundred + " nota(s) de R$ 100,00");
        Console.WriteLine(fity + " nota(s) de R$ 50,00");
        Console.WriteLine(twenty + " nota(s) de R$ 20,00");
        Console.WriteLine(ten + " nota(s) de R$ 10,00");
        Console.WriteLine(five + " nota(s) de R$ 5,00");
        Console.WriteLine(two + " nota(s) de R$ 2,00");
        Console.WriteLine(one + " nota(s) de R$ 1,00");

    }

}
