using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class Car:Vechicle,IDestroyable
    {

        public string DestructionSound { get; set; }
        public List<IDestroyable> DestroyablesNearby;
        public Car( float speed,string color):base(speed,color) {
            //Initialize the interaface's property with a value in the constructor
            DestructionSound = "boom.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine($"{DestructionSound} !");
            Console.WriteLine("Create Fire to nearby item!");
            foreach(IDestroyable item in DestroyablesNearby)
            {
                item.Destroy();
            }
        }
    }
}
