using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
  public  abstract class Ability
    {
        public abstract string Use();

        protected string Recharge()
        {
            string message = "Способность перезаряжается";
            return message;

        }

    }
}
