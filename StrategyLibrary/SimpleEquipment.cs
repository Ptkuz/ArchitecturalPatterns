using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLibrary
{
    public class SimpleEquipment : IEquipment
    {
        public string GetInfo()
        {
            string info = $"Простая комплектация автомобиля";
            return info;
        }
    }
}
