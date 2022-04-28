using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLibrary
{
    public class PremiumEquipment : IEquipment
    {
        public string GetInfo()
        {
            string info = $"Премиум комплектация автомобиля";
            return info;
        }
    }
}
