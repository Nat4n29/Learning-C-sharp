using System;
using System.Globalization;
using System.Collections.Generic;

namespace Lesson7POO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            int numEmployees;

            Console.Write("How many employees will be registered? ");
            numEmployees = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numEmployees; i++)
            {
                Console.WriteLine("Employee #" + i +":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                list.Add(new Employee(id, name, salary));
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase : ");
            int idEmployee = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x => x.Id == idEmployee);

            if( emp != null )
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This Id do not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            foreach(object obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}