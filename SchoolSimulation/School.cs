using System.Collections.Generic;
using System;

namespace SchoolSimulation
{
    public class School
    {
        public void GetStudentNameOfClass(StudentClass studentClass, List<Student> students)
        {
            //List<Student> selectedStudents = new List<Student>(10);
            foreach (var student in students)
            {
                if (student.ClassName == studentClass.Name)
                {
                    Console.WriteLine(student.Name);
                }
            }
        }    
    }
}
