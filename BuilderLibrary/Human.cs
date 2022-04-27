using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLibrary
{
    public class Human
    {
        public PC PCbuy(PCBuilder pcBuilder) 
        {
            pcBuilder.CreatePC();
            pcBuilder.SetCPU();
            pcBuilder.SetGPU();
            pcBuilder.SetMotherboard();
            pcBuilder.SetRAM();
            return pcBuilder.PC;
        }


    }
}
