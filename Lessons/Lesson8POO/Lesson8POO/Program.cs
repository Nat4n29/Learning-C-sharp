using System;

namespace Lesson8POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;

            string[] num = new string[2];
            num = Console.ReadLine().Split(' ');
            m = int.Parse(num[0]);
            n = int.Parse(num[1]);

            int[,] mat = new int[m,n];

            for(int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(s[j]);
                }
            }

            int num2 = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (mat[i, j] == num2)
                    {
                        Console.WriteLine($"Position {i}, {j}:");
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}