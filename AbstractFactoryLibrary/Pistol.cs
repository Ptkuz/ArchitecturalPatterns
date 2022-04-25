using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    class Pistol : Weapon
    {

        public Pistol(string nameGun, int numberOfRounds, int capacityShop, int numberGunShop) : base(nameGun, numberOfRounds, capacityShop, numberGunShop)
        {

        }

        public override string Hit()
        {
            string message;

            if (NumberOfRounds > 0 && NumberGunShop > 0)
            {
                NumberGunShop--;
                NumberOfRounds--;
                message = $"Пистолет {NameGun} произвел выстрел!";

            }
            else if (NumberOfRounds > 0 && NumberGunShop == 0)
            {
                string recharge = Recharge();
                NumberGunShop--;
                NumberOfRounds--;
                message = $"{recharge} Пистолет {NameGun} произвел выстрел!";
            }
            else
                message = "Не удалось выстрелить";

            return message;
        }



    }
}
