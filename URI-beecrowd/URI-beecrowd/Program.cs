﻿using System;
using System.Globalization;

class Program
{

    static void Main(string[] args)
    {
        int X, impar = 1;

        X = int.Parse(Console.ReadLine());

        do
        {
            if (impar % 2 != 0)
            {
                Console.WriteLine(impar);
                impar++;
            }
            else
            {
                impar++;
            }

        }while (impar <= X);
    }

}
