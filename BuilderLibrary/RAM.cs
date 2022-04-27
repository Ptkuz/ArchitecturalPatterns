using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLibrary
{
    public class RAM
    {
        public string Performance { get; set; }
        public string Model { get; set; }
        public int Size { get; set; }
        public double Frequency { get; set; }

        public RAM(string performance, string model, int size, double frequency) 
        { 
            Performance = performance;
            Model = model;
            Size = size;
            Frequency = frequency;

        }
    }
}
