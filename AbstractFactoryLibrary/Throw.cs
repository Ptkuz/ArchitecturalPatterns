using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    class Throw : Ability
    {
        public override string Use()
        {

            StringBuilder stringBuilder = new StringBuilder($"Использован способность Бросок \n");
            string rect = Recharge();
            stringBuilder.Append(rect);
            return stringBuilder.ToString();

        }

    }
}
