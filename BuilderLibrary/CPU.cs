using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLibrary
{
    public class CPU
    {
        public string Performance { get; set; }
        public string Model { get; set; }
        public double Frequency { get; set; }
        public int NumberCores { get; set; }
        public CPU(string performance, string model, double frequency, int numberCores)
        {
            this.Performance = performance;
            this.Model = model;
            this.Frequency = frequency;
            this.NumberCores = numberCores;
        }
    }
}
