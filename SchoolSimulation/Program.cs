using System;

namespace SchoolSimulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            school.AddEmployeeDepartment(new EmployeeDepartment("HR"));
            school.AddEmployeeDepartment(new EmployeeDepartment("Financial"));

            school.AddStudentClass(new StudentClass("FirstClass", "Kiss Péter"));
            school.AddStudentClass(new StudentClass("SecondClass", "Gábor Ágnes"));
            school.AddStudentClass(new StudentClass("ThirdClass", "Tóth Gabriella"));
            school.AddStudentClass(new StudentClass("FourthClass", "Szalma Ibolya"));

            school.AddTeacher(new Teacher("Kiss Péter", new DateTime(1974, 09, 10), 250000, 0.25F, "Math"));
            school.AddTeacher(new Teacher("Gábor Ágnes", new DateTime(1972, 08, 15), 250000, 0.27F, "Biology"));
            school.AddTeacher(new Teacher("Hasznos Boglárka", new DateTime(1990, 01, 28), 180000, 0.24F, "History"));
            school.AddTeacher(new Teacher("Tóth Gabriella", new DateTime(1989, 03, 22), 230000, 0.26F, "Physics"));
            school.AddTeacher(new Teacher("Szalma Ibolya", new DateTime(1978, 04, 02), 280000, 0.25F, "English"));

            school.AddStudent(new Student("A", new DateTime(2011, 02, 21), "FirstClass"));
            school.AddStudent(new Student("B", new DateTime(2011, 03, 11), "FirstClass"));
            school.AddStudent(new Student("C", new DateTime(2011, 04, 20), "FirstClass"));
            school.AddStudent(new Student("D", new DateTime(2011, 08, 28), "FirstClass"));
            school.AddStudent(new Student("E", new DateTime(2011, 06, 01), "FirstClass"));

            school.AddStudent(new Student("F", new DateTime(2010, 02, 21), "SecondClass"));
            school.AddStudent(new Student("G", new DateTime(2010, 01, 01), "SecondClass"));
            school.AddStudent(new Student("H", new DateTime(2010, 04, 11), "SecondClass"));
            school.AddStudent(new Student("J", new DateTime(2010, 05, 16), "SecondClass"));
            school.AddStudent(new Student("K", new DateTime(2010, 09, 23), "SecondClass"));

            school.AddStudent(new Student("L", new DateTime(2009, 02, 04), "ThirdClass"));
            school.AddStudent(new Student("M", new DateTime(2009, 07, 14), "ThirdClass"));
            school.AddStudent(new Student("N", new DateTime(2009, 05, 28), "ThirdClass"));
            school.AddStudent(new Student("O", new DateTime(2009, 05, 28), "ThirdClass"));
            school.AddStudent(new Student("P", new DateTime(2009, 05, 28), "ThirdClass"));

            school.AddStudent(new Student("Q", new DateTime(2008, 02, 02), "FourthClass"));
            school.AddStudent(new Student("R", new DateTime(2008, 05, 14), "FourthClass"));
            school.AddStudent(new Student("S", new DateTime(2008, 10, 26), "FourthClass"));
            school.AddStudent(new Student("T", new DateTime(2008, 12, 12), "FourthClass"));
            school.AddStudent(new Student("U", new DateTime(2008, 10, 22), "FourthClass"));

            school.SetDirector(new Director("Papp Gábor", new DateTime(1965, 11, 20), 450000, 0.30F, "Math", "Director"));

            school.AddAdmin(new Administrator("Tóth Virág", new DateTime(1990, 03, 21), 300000, 0.28F, "HR"));
            school.AddAdmin(new Administrator("Herceg Tamás", new DateTime(1996, 01, 01), 280000, 0.26F, "Financial"));


            Console.WriteLine();
            school.PrintResult();
            Console.WriteLine();
            school.GetStudentNameOfClass(school.studentClasses[2], school.students);
            Console.WriteLine();
            school.GetStudentNameOfClass(school.studentClasses[0], school.students);
            Console.ReadKey();
        }
    }
}
