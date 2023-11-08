using Lesson22POO.Entities;
using System;
using System.Globalization;

namespace Lesson22POO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter full file path: ");
                string path = Console.ReadLine();

                List<Employee> emp = new List<Employee>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] lines = sr.ReadLine().Split(',');
                        string name = lines[0];
                        string email = lines[1];
                        double salary = Double.Parse(lines[2], CultureInfo.InvariantCulture);

                        emp.Add(new Employee(name, email, salary));
                    }
                    sr.Close();
                }

                Console.Write("Enter salary: ");
                double _salary = double.Parse(Console.ReadLine());

                Console.WriteLine($"Email of people whose salary is more than {_salary}:");

                var orderEmail = emp.Where(e => e.Salary > _salary).OrderBy(e => e.Email).Select(e => e.Email);

                foreach (object email in orderEmail)
                {
                    Console.WriteLine(email);
                }

                var salarySum = emp.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {salarySum.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}