using Lesson18POO.Entities;
using System;
using System.Net.Http.Headers;

namespace Lesson18POO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter file full path: ");
                string path = Console.ReadLine();
                //@"D:\My Csharp projects\Learning-C-sharp\Lessons\Lesson18POO\Lesson18POO\in.txt"

                HashSet<LogRecord> records = new HashSet<LogRecord>();
                int numUsers = 0;

                using (StreamReader sr = new StreamReader(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime istant = DateTime.Parse(line[1]);

                        records.Add(new LogRecord(name, istant));
                    }

                    Console.WriteLine($"Total users: {records.Count}");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}