using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSimulation
{
    public class CreatorClass
    {
        public List<StudentClass> studentClasses = new List<StudentClass>(4);
        public List<EmployeeDepartment> employeeDepartments = new List<EmployeeDepartment>(5);
        public List<Teacher> teachers = new List<Teacher>(5);
        public List<Student> students = new List<Student>(20);

        public Director director = new Director("Papp Gábor", new DateTime(1965, 11, 20), 450000, 0.30F, "Math", "Director");

        public Administrator HRadmin = new Administrator("Tóth Virág", new DateTime(1990, 03, 21), 300000, 0.28F, "HR");
        public Administrator FinancialSpecialist = new Administrator("Herceg Tamás", new DateTime(1996, 01, 01), 280000, 0.26F, "FIN");

        public void CreatSchool()
        {
            studentClasses.Add(new StudentClass("FirstClass", "Kiss Péter"));
            studentClasses.Add(new StudentClass("SecondClass", "Gábor Ágnes"));
            studentClasses.Add(new StudentClass("ThirdClass", "Tóth Gabriella"));
            studentClasses.Add(new StudentClass("FourthClass", "Szalma Ibolya"));

            teachers.Add(new Teacher("Kiss Péter", new DateTime(1974, 09, 10), 250000, 0.25F, "Math"));
            teachers.Add(new Teacher("Gábor Ágnes", new DateTime(1972, 08, 15), 250000, 0.27F, "Biology"));
            teachers.Add(new Teacher("Hasznos Boglárka", new DateTime(1990, 01, 28), 180000, 0.24F, "History"));
            teachers.Add(new Teacher("Tóth Gabriella", new DateTime(1989, 03, 22), 230000, 0.26F, "Physics"));
            teachers.Add(new Teacher("Szalma Ibolya", new DateTime(1978, 04, 02), 280000, 0.25F, "English"));

            students.Add(new Student("A", new DateTime(2011, 02, 21), "FirstClass"));
            students.Add(new Student("B", new DateTime(2011, 03, 11), "FirstClass"));
            students.Add(new Student("C", new DateTime(2011, 04, 20), "FirstClass"));
            students.Add(new Student("D", new DateTime(2011, 08, 28), "FirstClass"));
            students.Add(new Student("E", new DateTime(2011, 06, 01), "FirstClass"));

            students.Add(new Student("F", new DateTime(2010, 02, 21), "SecondClass"));
            students.Add(new Student("G", new DateTime(2010, 01, 01), "SecondClass"));
            students.Add(new Student("H", new DateTime(2010, 04, 11), "SecondClass"));
            students.Add(new Student("J", new DateTime(2010, 05, 16), "SecondClass"));
            students.Add(new Student("K", new DateTime(2010, 09, 23), "SecondClass"));

            students.Add(new Student("L", new DateTime(2009, 02, 04), "ThirdClass"));
            students.Add(new Student("M", new DateTime(2009, 07, 14), "ThirdClass"));
            students.Add(new Student("N", new DateTime(2009, 05, 28), "ThirdClass"));
            students.Add(new Student("O", new DateTime(2009, 05, 28), "ThirdClass"));
            students.Add(new Student("P", new DateTime(2009, 05, 28), "ThirdClass"));

            students.Add(new Student("Q", new DateTime(2008, 02, 02), "FourthClass"));
            students.Add(new Student("R", new DateTime(2008, 05, 14), "FourthClass"));
            students.Add(new Student("S", new DateTime(2008, 10, 26), "FourthClass"));
            students.Add(new Student("T", new DateTime(2008, 12, 12), "FourthClass"));
            students.Add(new Student("U", new DateTime(2008, 10, 22), "FourthClass"));
        }

        public void PrintResult()
        {
            Console.WriteLine(director.ToString() + "Id: " + director.GetId());
            Console.WriteLine(HRadmin.ToString() + "Id: " + HRadmin.GetId());
            Console.WriteLine(FinancialSpecialist.ToString() + "Id: " + FinancialSpecialist.GetId());

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString() + "Id: " + student.GetId());
            }
            Console.WriteLine();

            foreach (var teacher in teachers)
            {
                Console.WriteLine(teacher.ToString() + "Id: " + teacher.GetId());
                FinancialSpecialist.CreateSalaryReport(teacher);
                Console.WriteLine();
            }
            FinancialSpecialist.CreateSalaryReport(HRadmin);
            Console.WriteLine();
            FinancialSpecialist.CreateSalaryReport(FinancialSpecialist);
        }
    }
}
