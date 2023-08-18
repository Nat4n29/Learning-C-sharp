using System;
using System.Globalization;

class SimpleCal
{

    static void Main(string[] args)
    {
        int cpeca1, cpeca2, vpeca1, vpeca2;
        double valor1, valor2, valorPagar;

        string[] vet, vet2;

        vet = Console.ReadLine().Split(' ');

        cpeca1 = int.Parse(vet[0]);
        vpeca1 = int.Parse(vet[1]);
        valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

        vet2 = Console.ReadLine().Split(' ');

        cpeca2 = int.Parse(vet2[0]);
        vpeca2 = int.Parse(vet2[1]);
        valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

        valorPagar = (double)(vpeca1 * valor1) + (vpeca2 * valor2);

        Console.WriteLine("VALOR A PAGAR: R$ " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));

    }

}
