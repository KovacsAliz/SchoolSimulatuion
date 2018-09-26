using System.Collections.Generic;
using System.Linq;

namespace SchoolSimulation
{
    public class StudentClass
    {
        public string Name { get; set; }
        public string HeadTeacher { get; set; }

        public StudentClass(string name, string headTeacher)
        {
            Name = name;
            HeadTeacher = headTeacher;
        }

        public int NumOfStudent(List<Student> studentList)
        {
            return studentList.Count();
        }
    }
}
