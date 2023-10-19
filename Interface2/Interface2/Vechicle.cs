using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class Vechicle 
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        public Vechicle() {
            Speed = 120f;
            Color = "Blue";
        }


        public Vechicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
