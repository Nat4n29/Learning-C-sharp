using System;

namespace Lesson20POO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 4000));
            list.Add(new Product("Boneca", 76));
            list.Add(new Product("Bola", 23));

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}