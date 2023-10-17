using Lesson17POO.Entities;
using Lesson17POO.Services;
using System.Globalization;

namespace Lesson17POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numInstallments = int.Parse(Console.ReadLine());
            Console.WriteLine("Installments:");

            Contract contract = new (number, date, value);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.processContract(contract, numInstallments);

            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}