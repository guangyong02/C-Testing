using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Parent - Base
    internal class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        public void SwtichOn()
        {
            IsOn = true;
        }
        public void SwtichOff()
        {
            IsOn = false;
        }
        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }
    }
}
