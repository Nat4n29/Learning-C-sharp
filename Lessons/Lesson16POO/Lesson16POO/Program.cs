using System;
using System.Globalization;

namespace Lesson16POO
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath1 = @"D:\My Csharp projects\Learning-C-sharp\Lessons\Lesson16POO\Lesson16POO\SourceFile.csv";

            try
            {
                Console.WriteLine("Name of the new folder:");
                string folderName = Console.ReadLine();

                string directoryPath = Path.GetDirectoryName(filePath1) + $"\\{folderName}";
                DirectoryInfo outDirectory = Directory.CreateDirectory(directoryPath);

                Console.WriteLine("Folder created! Local folder:");
                Console.WriteLine(Path.GetFullPath(directoryPath));

                string[] lines = File.ReadAllLines(filePath1);
                string[] files;

                Console.WriteLine("Name of the new file + extension:");
                string fileName = Console.ReadLine();

                string filePath2 = directoryPath + $"\\{fileName}";

                Console.WriteLine("File created! Local file:");
                Console.WriteLine(Path.GetFullPath(filePath2));

                using (StreamWriter sw = File.CreateText(filePath2))
                {
                    foreach (string s in lines)
                    {
                        files = s.Split(',');
                        float num1 = float.Parse(files[1], CultureInfo.InvariantCulture);
                        float num2 = float.Parse(files[2], CultureInfo.InvariantCulture);
                        float result = num1 * num2;

                        string final = $"{files[0]},{result.ToString("F2", CultureInfo.InvariantCulture)}";

                        sw.WriteLine(final);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}