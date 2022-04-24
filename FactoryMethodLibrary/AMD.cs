using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary
{
    public class AMD : Company
    {
        public string Name { get; set; }
        public AMD(string name) : base(name) { }

        public override Processor Create(string name)
        {
            return new ProcessorAMD(name);
        }


    }
}
