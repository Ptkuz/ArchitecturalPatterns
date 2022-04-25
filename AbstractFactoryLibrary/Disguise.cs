using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    abstract class Disguise : Ability
    {
        public override string Use()
        {

            StringBuilder stringBuilder = new StringBuilder($"Использован способность Маскировка \n");
            string rect = Recharge();
            stringBuilder.Append(rect);
            return stringBuilder.ToString();

        }

    }
}
