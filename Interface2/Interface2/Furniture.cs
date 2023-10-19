using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class Furniture
    {
        public string Style { get; set; }
        public string Material { get; set; }

        public Furniture() {
            Style = "Flower";
            Material = "Woods";

        }

        public Furniture(string style, string material)
        {
            Style = style;
            Material = material;
        }
    }
}
