using Lesson21POO.Entities;
using System;
using System.Globalization;

namespace Lesson21POO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Enter full file path: ");
                string path = Console.ReadLine();

                List<Products> products = new List<Products>();

                using(StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] lines = sr.ReadLine().Split(',');
                        string name = lines[0];
                        double price = double.Parse(lines[1], CultureInfo.InvariantCulture);

                        products.Add(new Products(name, price));
                    }
                    sr.Close();
                }

                double average = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine($"Average price: {average.ToString("F2", CultureInfo.InvariantCulture)}");

                IEnumerable<string> productsNames = products.Where(p => p.Price < average).OrderByDescending(p => p.Name).Select(p => p.Name);
                
                foreach(string p in productsNames)
                {
                    Console.WriteLine(p);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}