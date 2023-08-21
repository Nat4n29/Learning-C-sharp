using System;
using System.Globalization;

class Tabuada
{

    static void Main(string[] args)
    {
        int N;

        N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + " x " + N + " = " + (i * N));
        }
    }

}
