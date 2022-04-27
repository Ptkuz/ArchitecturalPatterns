using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeLibrary
{
    public class DarkTrooper : ITrooper
    {
        public int Id { get; set; }

        public DarkTrooper(int id)
        {
            Id = id;
        }

        public ITrooper Clone()
        {
            return new DarkTrooper(Id);

        }

        public string GetInfo()
        {
            string info = $"Темный штурмовик с ID - {Id}";
            return info;
        }


    }
}
