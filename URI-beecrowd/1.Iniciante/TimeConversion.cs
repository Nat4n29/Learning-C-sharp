using System;
using System.Globalization;

class TimeConversion
{

    static void Main(string[] args)
    {
        int hours, minutes, seconds, rest, value;

        value = int.Parse(Console.ReadLine());

        hours = value / 3600;
        rest = value % 3600;

        minutes = rest / 60;
        seconds = rest % 60;

        Console.WriteLine(hours + ":" + minutes + ":" + seconds);
    }

}
