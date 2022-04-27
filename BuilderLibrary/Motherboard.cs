using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLibrary
{
    public class Motherboard
    {
        public string Performance { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }
        public string Chipset { get; set; }

        public Motherboard(string performance, string model, string size, string chipset) 
        { 
            Performance = performance;
            Model = model;
            Size = size;
            Chipset = chipset;
        }

    }
}
