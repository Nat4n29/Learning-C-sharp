using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

class NotaProva
{

    static void Main(string[] args)
    {
        int nota;

        nota = int.Parse(Console.ReadLine());

        Console.WriteLine(Nota(nota));
    }
    static char Nota(int nota)
    {
        if(nota == 0)
        {
            nota = 'E';
        }
        else if(nota >= 1 && nota <= 35)
        {
            nota = 'D';
        }
        else if (nota >= 36 && nota <= 60)
        {
            nota = 'C';
        }
        else if (nota >= 61 && nota <= 85)
        {
            nota = 'B';
        }
        else if (nota >= 86 && nota <= 100)
        {
            nota = 'A';
        }
        return (char)nota;
    }

}
