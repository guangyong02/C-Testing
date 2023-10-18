using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryProject
{
    internal class Employee
    {
        private String _name;
        private String _role;
        private int _age;
        private float _rate;

        public String Name { get { return _name; } set { _name = value; } }
        public String Role { get { return _role; } set { _role = value; } }
        public int Age {  get { return _age; } set { _age = value; } }
        public float Rate { get { return _rate; } set { _rate = value; } }
        public float Salary { get { return _rate * 8 * 5 * 4 * 12; } }

        public Employee(string role,string name, int age, float rate)
        {
            _role = role;
            _name = name;
            _age = age;
            _rate = rate;
        }
    }
}
