using System;
using Lesson19POO.Entities;

namespace Lesson19POO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HashSet<Student> courseA = new HashSet<Student>();
                HashSet<Student> courseB = new HashSet<Student>();
                HashSet<Student> courseC = new HashSet<Student>();

                Console.Write("How many students for course A? ");
                int num = int.Parse(Console.ReadLine());

                for(int i = 0; i < num; i++)
                {
                    int id = int.Parse((Console.ReadLine()));
                    courseA.Add(new Student() { Id = id});
                }

                Console.Write("How many students for course B? ");
                num = int.Parse(Console.ReadLine());

                for (int i = 0; i < num; i++)
                {
                    int id = int.Parse((Console.ReadLine()));
                    courseB.Add(new Student() { Id = id });
                }

                Console.Write("How many students for course C? ");
                num = int.Parse(Console.ReadLine());

                for (int i = 0; i < num; i++)
                {
                    int id = int.Parse((Console.ReadLine()));
                    courseC.Add(new Student() { Id = id });
                }

                HashSet<Student> totalstudents = new HashSet<Student>();
                totalstudents.UnionWith(courseA);
                totalstudents.UnionWith(courseB);
                totalstudents.UnionWith(courseC);

                Console.WriteLine($"Total students: {totalstudents.Count}");
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}