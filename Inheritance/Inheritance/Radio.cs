using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Radio :ElectricalDevice
    {
        //Child
        public Radio(bool ison, string brand):base(ison, brand)
        {
            
        }   
        public void ListenRadio()
        {
            if (IsOn)
            {
                //listen to radio
                Console.WriteLine("Listening to the Radio");
            }
            else
            {
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}
