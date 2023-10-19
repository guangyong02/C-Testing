using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic
{
    //BMW is a car
   /*sealed*/ internal class BMW:Car
    {
        public string  Model { get; set; }
        private string _brand="BMW";
        public BMW(int hp,string color,string model):base(hp,color) { 
            Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine(_brand+" "+Model);
            base.ShowDetails();
        }

        public sealed override void Repair()
        {
            Console.WriteLine(_brand + " " + Model);
            base.Repair();
        }



    }
}
