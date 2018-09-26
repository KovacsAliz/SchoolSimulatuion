using System;

namespace SchoolSimulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreatorClass creator = new CreatorClass();
            School school = new School();
            creator.CreatSchool();
            Console.WriteLine();
            creator.PrintResult();
            Console.WriteLine();
            school.GetStudentNameOfClass(creator.studentClasses[2], creator.students);
            Console.WriteLine();
            school.GetStudentNameOfClass(creator.studentClasses[0], creator.students);
            Console.ReadKey();
        }
    }
}
