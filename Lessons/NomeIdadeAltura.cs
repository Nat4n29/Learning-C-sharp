using System;
using System.Globalization;
using System.Runtime.Serialization;

class NomeIdadeALtura
{

    static void Main(string[] args)
    {
        int N;
        int menor = 0;
        double porcent;
        double soma = 0.0;
        double altMed;

        N = int.Parse(Console.ReadLine());

        string[] nome;
        double[] idade;
        double[] altura;
        string[] input;

        nome = new string[N];
        idade = new double[N];
        altura = new double[N];

        for (int i = 0; i < N; i++) //inserir dados.
        {
            input = Console.ReadLine().Split(' ');
            nome[i] = input[0];
            idade[i] = double.Parse(input[1]);
            altura[i] = double.Parse(input[2], CultureInfo.InvariantCulture);
        }

        for (int i = 0; i < N; i++) //porcentagem.
        {

            if (idade[i] < 16)
            {
                menor++;
            }
        }

        for (int i = 0; i < N; i++) //media de altura.
        {
            soma = soma + altura[i];
        }

        altMed = soma / N;
        porcent = menor * 100.0 / N;

        Console.WriteLine("Altura media: " + altMed.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Pessoas com menos de 16 anos: " + porcent.ToString("F1", CultureInfo.InvariantCulture) + "%");
    }

}
