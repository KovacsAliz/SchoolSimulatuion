using System;

namespace SchoolSimulation
{
    public class Director : Employee, IHuman
    {
        public string Subject { get; set; }
        //private static Director director;

        public Director(string name, DateTime birthDate, int salary, float tax, string subject) 
            : base(name, birthDate, salary, tax)
        {
            Subject = subject;
        }

        public string GetId()
        {
            return Id;
        }

        public override string ToString()
        {
            return base.ToString() + "Subject:" + Subject;
        }
    }
}
