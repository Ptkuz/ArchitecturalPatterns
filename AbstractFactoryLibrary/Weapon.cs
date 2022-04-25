using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
   public abstract class Weapon
    {
        public string NameGun { get; set; }
        public int CapacityShop { get; set; }
        public int NumberOfRounds { get; set; }

        private int numberGunShop;
        public int NumberGunShop
        {
            get { return numberGunShop; }
            set
            {
                if (numberGunShop <= NumberOfRounds && numberGunShop <= CapacityShop)
                    numberGunShop = value;
            }
        }

        public Weapon(string nameGun, int numberOfRounds, int capacityShop, int numberGunShop)
        {
            NameGun = nameGun;
            NumberOfRounds = numberOfRounds;
            CapacityShop = capacityShop;
            NumberGunShop = numberGunShop;

        }


        public abstract string Hit();
        protected string Recharge()
        {
            string message = "Перезарядка произведена";
            if (NumberOfRounds > 0 && NumberGunShop == 0)
            {
                if (NumberOfRounds >= CapacityShop)
                {
                    NumberGunShop = CapacityShop;

                }
                else if (NumberOfRounds < CapacityShop)
                {
                    NumberGunShop = NumberOfRounds;
                }


            }
            else
                message = "Перезарядка не произведена";

            return message;

        }
    }
}
