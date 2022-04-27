using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeLibrary
{
    public class StormTrooper : ITrooper
    {
        public int Id { get; set; }

        public StormTrooper(int id) 
        { 
            Id = id;
        }

        public ITrooper Clone() 
        {
            return new StormTrooper(Id);
        
        }

        public string GetInfo()
        {
            string info = $"Штурмовик 501 легиона с ID - {Id}";
            return info;
        }


    }
}
