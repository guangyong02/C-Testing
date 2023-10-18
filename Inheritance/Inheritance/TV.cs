using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class TV :ElectricalDevice
    {
        //public bool IsOn { get; set; }
        //public string Brand { get; set; }
        public TV(bool ison, string brand) : base(ison, brand) 
        {

        }
        //public void SwtichOn()
        //{
        //    IsOn = true;
        //}
        //public void SwtichOff()
        //{
        //    IsOn = false;
        //}
        public void WatchingTV()
        {
            if (IsOn)
            {
                //listen to radio
                Console.WriteLine("Watching to the TV");
            }
            else
            {
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
