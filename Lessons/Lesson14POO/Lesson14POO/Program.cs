using Lesson14POO.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lesson14POO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            Console.Write("Enter the number of tax payers: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double yearEarn = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double hearthExpend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new IndAccount(hearthExpend, name, yearEarn));
                }
                if(type == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new CompAccount(name,yearEarn, employees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double total = 0.0;
            foreach(Account account in list)
            {
                Console.WriteLine(account);
                total += account.Tax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}