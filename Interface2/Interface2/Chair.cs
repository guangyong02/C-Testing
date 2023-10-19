using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class Chair :Furniture,IDestroyable
    {
        public string DestructionSound { get; set; }
        public Chair(string style, string material) :base(style,material)
        {
            DestructionSound = "Chair Boom.mp3";
        }
        
        
        public void Destroy()
        {
            Console.WriteLine($"The {Style} chair was Destroyed");
            Console.WriteLine($"Playing Destructions sound{DestructionSound}");
            Console.WriteLine("Spawning split Chair");
        }
    }
}
