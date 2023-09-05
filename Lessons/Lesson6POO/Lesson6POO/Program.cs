using System;
using System.Globalization;

namespace Lesson6POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] alu = new Aluguel[10];

            Console.Write("Quantos quartos serão alugados? ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= numero; i++)
            {
                int quarto;
                Console.WriteLine("Aluguel #" + i + ":");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());
                alu[quarto] = new Aluguel { Nome = nome, Email = email };
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados:");

            for(int i = 0; i < alu.Length; i++)
            {
                if (alu[i] != null)
                {
                    Console.WriteLine(i + ": " + alu[i].Nome +", " + alu[i].Email); 
                }
            }
        }
    }
}