using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            string nome;
            int quarto;
            double preco;

            string sobrenome;
            int idade;
            double altura;

            string[] vet;

            Console.WriteLine("Entre com seu nome completo:");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha):");
            vet = Console.ReadLine().Split(' ');

            sobrenome = vet[0];
            idade = int.Parse(vet[1]);
            altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}