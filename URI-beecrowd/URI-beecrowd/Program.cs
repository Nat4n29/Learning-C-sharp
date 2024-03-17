using System;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        int numTest = int.Parse(Console.ReadLine());

        int totalCobaia = 0;
        int totalCoelho = 0;
        int totalRato = 0;
        int totalSapo = 0;

        double percentCoelho = 0.0;
        double percentRato = 0.0;
        double percentSapo = 0.0;

        for (int i = 0; i < numTest; i++)
        {
            string[] cobaia = Console.ReadLine().Split(' ');
            int num = int.Parse(cobaia[0]);
            char cob = char.Parse(cobaia[1]);

            if(num >= 1 && num <= 15)
            {
                totalCobaia += num;

                if (cob == 'C')
                {
                    totalCoelho += num;
                }

                if (cob == 'R')
                {
                    totalRato += num;
                }

                if (cob == 'S')
                {
                    totalSapo += num;
                }
            }
            else
            {
                Exception ex = new Exception();
                Console.WriteLine(ex.Message.ToString());
            }
            
        }

        percentCoelho = totalCoelho / (totalCobaia / 100.0);
        percentRato = totalRato / (totalCobaia / 100.0);
        percentSapo = totalSapo / (totalCobaia / 100.0);

        Console.WriteLine($"Total: {totalCobaia} cobaias");
        Console.WriteLine($"Total de coelhos: {totalCoelho}");
        Console.WriteLine($"Total de ratos: {totalRato}");
        Console.WriteLine($"Total de sapos: {totalSapo}");

        Console.WriteLine($"Percentual de coelhos: {percentCoelho.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de ratos: {percentRato.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de sapos: {percentSapo.ToString("F2", CultureInfo.InvariantCulture)} %");
    }
}
