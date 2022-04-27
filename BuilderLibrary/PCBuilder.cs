using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLibrary
{
    public abstract class PCBuilder
    {
        public PC PC { get; private set; }

        public void CreatePC() 
        {
            PC = new PC();
        
        }

        public abstract void SetCPU();
        public abstract void SetGPU();
        public abstract void SetMotherboard();
        public abstract void SetRAM();
    }
}
