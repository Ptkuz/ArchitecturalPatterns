using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary
{
    public class Intel : Company
    {
        public string Name { get; set; }
        public Intel(string name) : base(name) { }

        public override Processor Create(string name)
        {
            return new ProcessorIntel(name);
        }


    }
}
