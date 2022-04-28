using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLibrary
{
    public class Car
    {
        public string Performance { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public IEquipment Equipment { get; set; }

        public Car(string performance, string model, decimal basePrice, IEquipment equipment) 
        { 
            Performance = performance;
            Model = model;
            Price = basePrice;
            Equipment = equipment;
           

        }

        public override string ToString()
        {
            string complect = Equipment.GetInfo();
            string info = $"{Performance} {Model} с базовой ценой в {Price} имеет комплектацию" +
                $"{complect}";
            return info;
        }

    }
}
