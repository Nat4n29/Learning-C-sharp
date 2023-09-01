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
        public int ContaNum { get; private set; }
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public string Dados { get; private set; }

        

        public ContaBancaria(int conta, string nome, double valor)
        {
            ContaNum = conta;
            Nome = nome;
            Valor = valor;
            Dados = "Conta " + ContaNum + ", Titular: " + Nome + ", Saldo: $ " + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }

        public double DepInic(double valor)
        {
            return Valor += valor;
        }

        public double Deposito(double depoValor)
        {
            return Valor += depoValor;
        }

        public double Saque(double saqValor)
        {
            Valor -= saqValor;

            return Valor -= 5.0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
