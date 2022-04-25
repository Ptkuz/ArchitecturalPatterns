using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    public class BioticFactory : ShepardClass
    {
        public override Weapon CreateWeapon()
        {
            Pistol pistol = new Pistol("Фаланга", 23, 6, 6);
            return pistol;
        }

        public override Ability CreateAbility()
        {
            Throw @throw = new Throw();
            return @throw;
        }

    }
}
