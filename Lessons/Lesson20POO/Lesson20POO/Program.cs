using System;

namespace Lesson20POO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter file full path: ");
                string patch = Console.ReadLine();

                using (StreamReader sr = new StreamReader(patch))
                {
                    Dictionary<string, int> nameVote = new Dictionary<string, int>();

                    while (!(sr.EndOfStream))
                    {
                        string[] file = sr.ReadLine().Split(',');

                        if (nameVote.ContainsKey(file[0]) == true)
                        {
                            nameVote[file[0]] += int.Parse(file[1]);
                        }
                        else
                        {
                            nameVote.Add(file[0], int.Parse(file[1]));
                        }
                    }
                    foreach (KeyValuePair<string, int> pair in nameVote)
                    {
                        Console.WriteLine($"{pair.Key}: {pair.Value}");
                    }

                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}