using System.Collections.Generic;
using System;

namespace SchoolSimulation
{
    public class School
    {
        public readonly List<StudentClass> studentClasses = new List<StudentClass>(4); //TODO private readonly
        private readonly List<EmployeeDepartment> employeeDepartments = new List<EmployeeDepartment>(2);
        private readonly List<Administrator> administrators = new List<Administrator>(2);
        private readonly List<Teacher> teachers = new List<Teacher>(5);
        public readonly List<Student> students = new List<Student>(20); //TODO private readonly

        public Director Director { get; private set; }
        //public Director Director { get; private set; }

        public School()
        {
            Director = null;
        }

        public void SetDirector(Director director)
        {
            Director = director;
        }

        public void AddAdmin(Administrator administrator)
        {
            administrators.Add(administrator);
        }

        public void AddStudentClass(StudentClass studentClass)
        {
            studentClasses.Add(studentClass);
        }

        public void AddEmployeeDepartment(EmployeeDepartment employeeDepartment)
        {
            employeeDepartments.Add(employeeDepartment);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void PrintResult()
        {
            Console.WriteLine(Director.ToString() + "Id: " + Director.GetId());
            
            foreach (var admin in administrators)
            {
                Console.WriteLine(admin.ToString() + "Id: " + admin.GetId());
                administrators[0].CreateSalaryReport(admin);
            }
            Console.WriteLine();

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString() + "Id: " + student.GetId());
            }
            Console.WriteLine();

            foreach (var teacher in teachers)
            {
                Console.WriteLine(teacher.ToString() + "Id: " + teacher.GetId());
                administrators[0].CreateSalaryReport(teacher);
                Console.WriteLine();
            }
        }

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
