using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.ReadKey();
        }
    }
}
