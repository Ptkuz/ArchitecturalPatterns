using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    class Adrenalin : Ability
    {
        public override string Use()
        {

            StringBuilder stringBuilder = new StringBuilder($"Использован способность Адреналин \n");
            string rect = Recharge();
            stringBuilder.Append(rect);
            return stringBuilder.ToString();

        }

    }
}
