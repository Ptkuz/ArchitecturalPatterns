using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    class AssaultRifle : Weapon
    {

        public AssaultRifle(string nameGun, int numberOfRounds, int capacityShop, int numberGunShop) : base(nameGun, numberOfRounds, capacityShop, numberGunShop)
        {

        }

        public override string Hit()
        {
            string message;

            if (NumberOfRounds > 0 && NumberGunShop > 0)
            {
                NumberGunShop--;
                NumberOfRounds--;
                message = $"Штурмовая винтовка {NameGun} произвела выстрел!";

            }
            else if (NumberOfRounds > 0 && NumberGunShop == 0)
            {
               string recharge = Recharge();
                NumberGunShop--;
                NumberOfRounds--;
                message = $"{recharge} Штурмовая винтовка {NameGun} произвела выстрел!";
            }
            else
                message = "Не удалось выстрелить";

            return message;
        }



    }
}
