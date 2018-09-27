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
        private static int _idCounter = 1;
        public char FirstLetter { get { return Name[0]; } set { FirstLetter = value; } }

        public Employee(string name, DateTime birthDate, int salary, float tax)
        {
            Name = name;
            BirtDate = birthDate;
            Salary = salary;
            Tax = tax;
            Id =  FirstLetter.ToString() + _idCounter;
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
