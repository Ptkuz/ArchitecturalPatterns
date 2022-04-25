using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
   public class Shepard
    {
        private Weapon weapon;
        private Ability ability;

        public Shepard(ShepardClass soldierFactory)
        {
            weapon = soldierFactory.CreateWeapon();
            ability = soldierFactory.CreateAbility();

        }

        public void Hit(out string message)
        {

            message = weapon.Hit();

        }

        public void Use(out string message)
        {
           message = ability.Use();

        }

    }

}
