using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3POO
{
    internal class Aluno
    {
        public string Nome;
        public double A, B, C;

        public double NotaFinal()
        {
            return A + B + C;
        }

        public void Resultado()
        {
            double resultado = 60 - NotaFinal();
            if(NotaFinal() < 60)
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + resultado.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
        }
    }
}
