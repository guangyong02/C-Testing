using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    internal class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public bool IsWorking;

        public Employee(string name,string firstName,int salary)
        {
            Name= name;
            FirstName= firstName;
            Salary= salary;
            IsWorking = false;
        }

        public virtual void Work()
        {

        }
        public virtual void Pause()
        {
            Console.WriteLine("Employee lunchBreak");
        }

        public override string ToString()
        {
            return Name +" "+ FirstName +" " + Salary;
        }
    }
}
