using System;
using System.Globalization;
using System.Runtime.Serialization;

class Matriz
{

    static void Main(string[] args)
    {
        int M, N;

        string[] vet;
        int[,] matriz;

        vet = Console.ReadLine().Split(' ');
        M = int.Parse(vet[0]);
        N = int.Parse(vet[1]);

        matriz = new int[M, N];

        for (int i = 0; i < M; i++)
        {
            string[] s = Console.ReadLine().Split(' ');

            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = int.Parse(s[j]);
            }
        }

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

}
