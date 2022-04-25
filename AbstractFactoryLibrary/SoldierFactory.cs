using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
   public class SoldierFactory : ShepardClass
    {
        public override Weapon CreateWeapon()
        {


            AssaultRifle assaultRifle = new AssaultRifle("Матыга", 126, 5, 5);



            return assaultRifle;

        }

        public override Ability CreateAbility()
        {
            Adrenalin adrenalin = new Adrenalin();
            return adrenalin;
        }




    }

    
}
