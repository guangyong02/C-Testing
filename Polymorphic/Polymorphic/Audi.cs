using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic
{
    //Audi is a car
    internal class Audi : Car
    {
        private string _brand="Audi";
        public Audi(int HP, string Color) : base(HP, Color)
        {
        }
        public new void ShowDetails()
        {
            Console.WriteLine("Audi " + _brand);
            base.ShowDetails();
        }

        public override void Repair()
        {
            Console.WriteLine("Audi " + _brand);
            base.Repair();
        }
    }
}
