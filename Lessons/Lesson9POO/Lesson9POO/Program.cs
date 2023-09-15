using Lesson9POO.Entities;
using Lesson9POO.Entities.Enums;
using System;
using System.Globalization;

namespace Lesson9POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker;

            Console.Write("Enter department's name: ");
            Department deptName = new Department(Console.ReadLine());
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            worker = new Worker(name, level, baseSalary, deptName);

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, duration);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            double income = worker.income(year, month);

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Deparment: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {income.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}