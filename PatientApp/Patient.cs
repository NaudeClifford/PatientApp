using System;
using System.Collections.Generic;
using System.Text;

namespace PatientApp
{
    public class Patient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int Priority { get; set; }

        public Patient(int id, string name, int age, int priority)
        {
            Id = id;
            Name = name;
            Age = age;
            Priority = priority;
        }
    }
}
