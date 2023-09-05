using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5POO
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular  { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string nome, double valor)
        {
            Numero = conta;
            Titular = nome;
            Saldo = valor;
        }

        public ContaBancaria(){}

        public double DepInic(double valor)
        {
            return Deposito(valor);
        }

        public double Deposito(double quantia)
        {
            return Saldo += quantia;
        }

        public double Saque(double quantia)
        {
            Saldo -= quantia;

            return Saldo -= 5.0;
        }

        public override string ToString()
        {
            return "Conta " 
                + Numero 
                + ", Titular: " 
                + Titular + ", Saldo: $ " 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
