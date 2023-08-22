using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization;

class DiagonalNegativo
{

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int negativos = 0;

        int[,] matriz = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            string[] s = (Console.ReadLine().Split(' '));

            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = int.Parse(s[j]);
            }
        }

        Console.WriteLine("DIAGONAL PRINCIPAL:");
        for (int i = 0; i < N; i++)
        {
            int valor = 0;

            valor = matriz[i, i];

            Console.Write(valor + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matriz[i, j] < 0)
                {
                    negativos++;
                }
            }
        }
        Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + negativos);

    }

}
