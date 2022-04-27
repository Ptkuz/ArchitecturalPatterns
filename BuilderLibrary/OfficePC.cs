using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLibrary
{
    public class OfficePC : PCBuilder
    {
        public override void SetCPU()
        {
             this.PC.Processor = new CPU("AMD", "Ryzen 3 2500", 3.0, 4);
        }

        public override void SetGPU()
        {
             this.PC.Videocard = new GPU("Nvidia", "GeForce GTX 1030", 4);

        }

        public override void SetMotherboard()
        {
             this.PC.Motherboard = new Motherboard("Asus", "B450 gold", "ATX", "B450");
        }

        public override void SetRAM()
        {
            RAM ram1 = new RAM("AMD", "Model1", 16, 2600);
            RAM ram2 = new RAM("AMD", "Model1", 16, 2600);

            this.PC.RAMS = new List<RAM>() { ram1, ram2 };


        }

    }
}
