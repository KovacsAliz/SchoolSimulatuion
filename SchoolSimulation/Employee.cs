using System;

namespace SchoolSimulation
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public DateTime BirtDate { get; }
        public int Salary { get; set; }
        public float Tax { get; set; }
        public string Id { get; set; }
        public bool HasMscDegree { get; set; }
        public bool HasBADegree { get; set; }
        public bool IsTeaching { get; set; }
        private static int _idCounter = 1;

        public Employee(string name, DateTime birthDate, int salary, float tax)
        {
            Name = name;
            BirtDate = birthDate;
            Salary = salary;
            Tax = tax;
            Id = Name + _idCounter;
            _idCounter++;
        }

        public override string ToString()
        {
            return "Name:" + Name + ", " +
                    "Birth of date:" + BirtDate + ", " +
                    "Salary:" + Salary + ", " +
                    "Tax:" + Tax + ", "; 
        }
    }  
}
