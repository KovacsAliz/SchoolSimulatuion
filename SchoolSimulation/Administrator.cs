using System;

namespace SchoolSimulation
{
    public class Administrator : Employee, IHuman
    {
        public string Department { get; }

        public Administrator(string name, DateTime birthDate, int salary, float tax, string department) : base(name, birthDate, salary, tax)
        {
            Department = department;
        }

        public void CreateSalaryReport(int salary, float tax)
        {
            float _salaryReport = salary * tax;
            Console.WriteLine(_salaryReport);
        }

        public string GetId()
        {
            return Id;
        }

        public override string ToString()
        {
            return base.ToString() + "StudentClass:" + Department;
        }
    }
}
