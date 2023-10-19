using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    internal class Dog : Animal 
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age, string gender):base(name, age,gender) { 
            IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }
        public override void MakeSound()
        {
            Console.WriteLine("Wuuuf !");
        }
        public override void Play()
        {

            if (IsHappy)
            {
                base.Play();
            }
            else
                Console.WriteLine($"{Name} is not happy");
        }
    }
}
