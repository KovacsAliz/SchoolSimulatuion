using System.Collections.Generic;
using System;

namespace SchoolSimulation
{
    public class School
    {
        public void GetStudentNameOfClass(StudentClass studentClass, List<Student> students)
        {
            foreach (var student in students)
            {
                if (student.ClassName == studentClass.Name)
                {
                    Console.WriteLine(@"{0} student belong to the {1}.", student.Name, studentClass.Name);
                }
            }
        }    
    }
}
