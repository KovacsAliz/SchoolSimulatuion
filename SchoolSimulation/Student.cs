using System;

namespace SchoolSimulation
{
    public class Student : IHuman
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; }
        public string ClassName { get; set; }
        public string Id { get; set; }
        private static int _idCounter = 1;

        public Student(string name, DateTime birthDate, string className)
        {
            Name = name;
            BirthDate = birthDate;
            ClassName = className;
            Id = Name + _idCounter;
            _idCounter++;
        }

        public string GetId()
        {
            return Id;
        }

        public override string ToString()
        {
            return "Name:" + Name + ", " +
                    "Birth of date:" + BirthDate;
        }
    }
}
