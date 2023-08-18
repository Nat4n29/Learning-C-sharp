using System;
using System.Globalization;

class IndTea
{

    static void Main(string[] args)
    {
        int A, B, C, D, E, T, result;

        string[] vet;

        T = int.Parse(Console.ReadLine());
        vet = Console.ReadLine().Split(' ');

        A = int.Parse(vet[0]);
        B = int.Parse(vet[1]);
        C = int.Parse(vet[2]);
        D = int.Parse(vet[3]);
        E = int.Parse(vet[4]);

        if (A == T)
        {
            A = 1;
        }
        else
        {
            A = 0;
        }
        if (B == T)
        {
            B = 1;
        }
        else
        {
            B = 0;
        }
        if (C == T)
        {
            C = 1;
        }
        else
        {
            C = 0;
        }
        if (D == T)
        {
            D = 1;
        }
        else
        {
            D = 0;
        }
        if (E == T)
        {
            E = 1;
        }
        else
        {
            E = 0;
        }

        result = A + B + C + D + E;

        Console.WriteLine(result);
    }

}
