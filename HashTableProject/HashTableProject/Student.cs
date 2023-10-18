using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProject
{
    internal class Student
    {
        private int _id;
        private string _name;
        private double _GPA;

        //public int Id { get; set; }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public double GPA
        {
            get
            {
                return _GPA;
            }
            set
            {
                _GPA = value;
            }
        }
        public string NickName { get; set; }
        

        public Student(int id, string name, double GPA, string nickName)
        {
            _id = id;
            _name = name;
            _GPA = GPA;
            NickName = nickName;
        }
    }
}
