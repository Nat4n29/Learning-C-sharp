﻿using System;
using System.Globalization;

class Program
{

    static void Main(string[] args)
    {
        int correctPassword = 2002;
        int password;

        password = int.Parse(Console.ReadLine());

        while (password != correctPassword)
        {
            Console.WriteLine("Senha Invalida");
            password = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Acesso Permitido");
    }

}
