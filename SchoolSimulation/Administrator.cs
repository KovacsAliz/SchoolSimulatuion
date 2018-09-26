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

        public void CreateSalaryReport(Employee employee)
        {
            float _salaryReport = employee.Salary * (1 - employee.Tax);
            Console.WriteLine(@"{0} employee's net salary: {1}", employee.Name, _salaryReport);
        }

        public string GetId()
        {
            return Id;
        }

        public override string ToString()
        {
            return base.ToString() + "Department:" + Department + ", ";
        }
    }
}
