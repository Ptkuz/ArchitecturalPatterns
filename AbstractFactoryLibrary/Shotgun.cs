using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    class Shotgun : Weapon
    {

        public Shotgun(string nameGun, int numberOfRounds, int capacityShop, int numberGunShop) : base(nameGun, numberOfRounds, capacityShop, numberGunShop)
        {

        }

        public override string Hit()
        {
            string message;

            if (NumberOfRounds > 0 && NumberGunShop > 0)
            {
                NumberGunShop--;
                NumberOfRounds--;
                message = $"Дробовик {NameGun} произвел выстрел!";

            }
            else if (NumberOfRounds > 0 && NumberGunShop == 0)
            {
                string recharge = Recharge();
                NumberGunShop--;
                NumberOfRounds--;
                message = $"{recharge} Дробовик {NameGun} произвел выстрел!";
            }
            else
                message = "Не удалось выстрелить";

            return message;
        }



    }

}
