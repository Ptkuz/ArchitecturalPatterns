using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLibrary
{
    public class GamePC : PCBuilder
    {
        public override void SetCPU()
        {
            this.PC.Processor = new CPU("AMD", "Ryzen 9 3900X", 5.0, 12);
        }

        public override void SetGPU()
        {
            this.PC.Videocard = new GPU("Nvidia", "GeForce RTX 3090 Ti", 16);

        }

        public override void SetMotherboard()
        {
             this.PC.Motherboard = new Motherboard("Asus", "ROG Strix X-570 E Gaming", "ATX", "X-570");
        }

        public override void SetRAM()
        {
            RAM ram1 = new RAM("HyperX", "Fury", 16, 3800);
            RAM ram2 = new RAM("HyperX", "Fury", 16, 3800);
            RAM ram3 = new RAM("HyperX", "Fury", 16, 3800);
            RAM ram4 = new RAM("HyperX", "Fury", 16, 3800);

            this.PC.RAMS = new List<RAM>() { ram1,ram2,ram3,ram4 };

            
        }

    }
}
