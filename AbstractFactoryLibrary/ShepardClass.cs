using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
  public  abstract class ShepardClass
    {
        public abstract Weapon CreateWeapon();
        public abstract Ability CreateAbility();

    }
}
