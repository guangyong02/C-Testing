using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    internal class Car
    {
        //private fields
        //access modifier private
        private string _name;
        private int _hp;
        private string _color;

        //automatically create a variable MaxSpeed that only accessible using prop
        //public int MaxSpeed { get; } = 10;

        private int _maxSpeed;
        public int MaxSpeed { set { _maxSpeed = value; } }



        public string Name { 
            get { return _name; }  //get accesor
            set {
                if (value == "") { _name = "Null"; }
                else { _name= value; }} //set accessor
        }
        //public string getHp()
        //{
        //    return _hp + "Horse power";
        //}
        //public string getName()
        //{
        //    return _name;
        //}
        //public void setName(string name)
        //{
        //    if (name=="")
        //    {
        //        _name = "Default";
        //    }
        //    else
        //    {
        //        _name=name;
        //    }

        //}

        public Car() { 

            _name = string.Empty;
            _hp = 0;    
            _color = string.Empty;
            //_maxSpeed = 150;
        }

        public Car(string name, string color="black") {
            _name = name;
            _hp = 0;
            _color = color;
            Console.WriteLine("{0} was created",name);
        }

        public Car(string name, int hp = 0)
        {
            _name = name;
            _hp = hp;
            _color = "Red";
            Console.WriteLine("{0} was created", name);
        }
        public Car(string name, int hp, string color)
        {
            _name = name;
            _hp = hp;
            _color = color;
            Console.WriteLine("{0} was created", name);
        }


        public void Drive()
        {
            Console.WriteLine("{0} Car is driving!",_name);
        }
        public void Stop() {
            Console.WriteLine("{0} Stop!",_name);
        }

        public string toString()
        {
            return _name +" "+ _hp + " " +_color;
        }
    }
}
