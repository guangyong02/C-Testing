using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesProject
{
    abstract internal class Shape
    {
        public string  Name { get; set; }
        public virtual void GetInfo() {
            Console.WriteLine($"\nThis is a {Name}.");
        }

        //An abstract function cannot declare the body
        public abstract double Volume();

    }
}
